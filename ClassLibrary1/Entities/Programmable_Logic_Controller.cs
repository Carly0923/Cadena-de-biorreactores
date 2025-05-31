using Dominio_Fermentación.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio_Fermentación.Entities.Abstract;
using Dominio_Fermentación.Common;
using Dominio_Fermentación.Rules;
using Dominio_Fermentación.Errors;
using FluentResults;
using System.Collections;
using System.Net;

/// No es necesario usar el namespace del value object, por eso lo quite
namespace Dominio_Fermentación.Entities
{
  public abstract class Programmable_Logic_Controller
        : Entity
    {
   #region Propiedades
   /// <summary> Número de identificación del PLC </summary>
   public Id_unidad Id_PLC { get; set; }
   /// <summary> La marca del PLC es un enumerado declarado en Types </summary>
   public Marca_PLC marca_PLC { get; set; } = Marca_PLC.S7_300;
   /// <summary> Dirección IP </summary>
   public Network_Address IP_Address { get; set; }
   /// <summary> Estado de funcionamiento del PLC </summary>
   public Estado_equipo estado_equipo_PLC { get; set; } = Estado_equipo.Executing;
   #endregion
   ///<summary> Constructor </summary>
   public Programmable_Logic_Controller(Id_unidad id_number, Network_Address ip_address, Guid id) : base(id)
   {
     Id_PLC = id_number;
     IP_Address = ip_address;
   }
        /// <summary>
        /// Lleva al dispositivo a un estado de falla.
        /// </summary>
        /// <exception cref="InvalidOperationException"></exception>
        public Result GetIntoFaultState()
        {
            var result = CheckRules(
                new EquipmentCannotGoIntoFaultStateIfIsAlreadyOnIt(estado_equipo_PLC));
            if (result.IsFailed)
                return result;

            estado_equipo_PLC = Estado_equipo.Faulted;
            return Result.Ok();
        }

        /// <summary>
        /// Saca el dispositivo del estado de falla.
        /// </summary>
        /// <exception cref="InvalidOperationException"></exception>
        public Result GetOutOfFaultState()
        {
            var result = CheckRules(
                new EquipmentCannotGetOutOfFaultedStateIfItsNotInIt(estado_equipo_PLC));
            if (result.IsFailed)
                return result;

            estado_equipo_PLC = Estado_equipo.Idle;
            return Result.Ok();
        }
    }

}
