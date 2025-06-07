using Dominio_Fermentación.Common;
using Dominio_Fermentación.Entities.Abstract;
using Dominio_Fermentación.Rules;
using Dominio_Fermentación.Errors;
using Dominio_Fermentación.Types;
using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio_Fermentación.Entities
{
    /// <summary>
    /// Clase base para los dispositivos de automatización industrial.
    /// </summary>
    public abstract class AutomationDevice
        : Entity, IStatefulEquipment
    {

        #region Properties

        /// <summary>
        /// Dirección IP del dispositivo en la red.
        /// </summary>
        public Network_Address Address { get; set; }

        /// <summary>
        /// Estado actual del dispositivo.
        /// </summary>
        public Estado_equipo State { get; private set; }

        /// <summary>
        /// Unidades asociadas a dispositivos de automatización.
        /// </summary>
<<<<<<< HEAD:ClassLibrary1/Entities/AutomatationDevice.cs
        public List<Programmable_Logic_Controller> ProgrammableLogicController { get; set; } = new();

        public Estado_equipo Estado => throw new NotImplementedException();

        #endregion

        public AutomationDevice(
            Guid id,
            Network_Address address,
            Estado_equipo state)
            : base(id)
        {
            Address = address;
            State = state;
        }

=======
        public List<Unit> Units { get; private set; } = new();

        public Estado_equipo Estado => throw new NotImplementedException();

        #endregion

        public AutomationDevice(
            Guid id,
            Network_Address address,
            Estado_equipo state)
            : base(id)
        {
            Address = address;
            State = state;
        }

>>>>>>> parent of d1293e5 (Arreglar CheckableObject, IStatefulEquipment, Automation Device, Batch, Network Address, PLC y IStatefulEquipmentErrors.):ClassLibrary1/Entities/AutomationDevice.cs
        /// <summary>
        /// Lleva al dispositivo a un estado de falla.
        /// </summary>
        /// <exception cref="InvalidOperationException"></exception>
        public Result GetIntoFaultState()
        {
            var result = CheckRules(
                new EquipmentCannotGoIntoFaultStateIfIsAlreadyOnIt(State));
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

<<<<<<< HEAD:ClassLibrary1/Entities/AutomatationDevice.cs
        public Result GetintoFault()
        {
            throw new NotImplementedException();
        }

        public Result GetoutFault()
        {
            throw new NotImplementedException();
        }
=======

>>>>>>> parent of d1293e5 (Arreglar CheckableObject, IStatefulEquipment, Automation Device, Batch, Network Address, PLC y IStatefulEquipmentErrors.):ClassLibrary1/Entities/AutomationDevice.cs
    }
}
