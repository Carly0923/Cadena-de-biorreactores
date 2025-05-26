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
using Dominio_Fermentación.ValueObjects;
using FluentResults;
using System.Collections;
using System.Net;

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
   public string IP_Address { get; set; }
   /// <summary> Estado de funcionamiento del PLC </summary>
   public Estado_equipo estado_equipo_PLC { get; set; } = Estado_equipo.Executing;
   #endregion
   ///<summary> Constructor </summary>
   protected Programmable_Logic_Controller() 
        {
        }
   public Programmable_Logic_Controller(Id_unidad id_number, string ip_address)
            
    {
     Id_PLC = id_number;
     IP_Address = ip_address;
    }
        public Programmable_Logic_Controller(
    Guid id,
    Network_Address address,
    Estado_equipo state)
    : base(id, address, state)
        {
            Address = address;
            State = state;
        }

        /// <summary>
        /// Lleva al dispositivo a un estado de falla.
        /// </summary>
        /// <exception cref="InvalidOperationException"></exception>
        public Result GetIntoFaultState()
        {
            var result = CheckRules(
                new EquipmentCannotGoIntoFaultStateIfIsAlreadyOnIt(IP_Address));
            if (result.IsFailed)
                return result;

            State = Estado_equipo.Faulted;
            return Result.Ok();
        }

        /// <summary>
        /// Saca el dispositivo del estado de falla.
        /// </summary>
        /// <exception cref="InvalidOperationException"></exception>
        public Result GetOutOfFaultState()
        {
            var result = CheckRules(
                new EquipmentCannotGetOutOfFaultedStateIfItsNotInIt(State));
            if (result.IsFailed)
                return result;

            State = Estado_equipo.Idle;
            return Result.Ok();
        }
    }

}
