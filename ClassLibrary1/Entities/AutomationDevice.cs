using Dominio_Fermentación.Common;
using Dominio_Fermentación.Entities.Abstract;
using Dominio_Fermentación.Rules;
using Dominio_Fermentación.Errors;
using Dominio_Fermentación.Types;
using Dominio_Fermentación.ValueObjects;
using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio_Fermentación.Entities
{
    /// <summary> Clase base para los dispositivos de automatización industrial.  </summary>
    public abstract class AutomationDevice
        : Entity, IStatefulEquipment
    {

        #region Properties
        /// <summary> Dirección IP del dispositivo en la red. </summary>
        public Dirección_Red Address { get; set; }

        /// <summary> Estado actual del dispositivo. </summary>
        public Estado_equipo Estado { get; private set; }
        /// <summary> Unidades asociadas a dispositivos de automatización. </summary>
        public List<Unidad> Unidades { get; private set; } = new();
        #endregion

        #region Métodos
        public AutomationDevice(Guid id, Dirección_Red address, Estado_equipo state) : base(id)
        {
            Address = address;
            Estado = state;
        }
        /// <summary> Lleva al dispositivo a un estado de falla </summary>
        /// <exception cref="InvalidOperationException"></exception>
        public Result GetintoFault()
        {
            var result = CheckRules(
                new EquipmentCannotGoIntoFaultStateIfIsAlreadyOnIt(Estado));
            if (result.IsFailed)
                return result;

            Estado = Estado_equipo.Faulted;
            return Result.Ok();
        }

        /// <summary> Saca el dispositivo del estado de falla. </summary>
        /// <exception cref="InvalidOperationException"></exception>
        public Result GetoutFault()
        {
            var result = CheckRules(
                new EquipmentCannotGetOutOfFaultedStateIfItsNotInIt(Estado));
            if (result.IsFailed)
                return result;

            Estado = Estado_equipo.Idle;
            return Result.Ok();
        }
        #endregion
    }
}