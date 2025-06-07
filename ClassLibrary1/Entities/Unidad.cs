using Dominio_Fermentación.Common;
using Dominio_Fermentación.Entities.Abstract;
using Dominio_Fermentación.Errors;
using Dominio_Fermentación.Rules;
using Dominio_Fermentación.Types;
using FluentResults;
using Microsoft.VisualBasic;

namespace Dominio_Fermentación.Entities
{
    /// <summary> Modela un equipo automático. </summary>
    public class Unidad
        : Entity, IStatefulEquipment
    {
        #region Properties
        /// <summary> Nombre del equipo. </summary>
        public string Name { get; set; }
        /// <summary> Código del equipo. </summary>
        public UnitIdentificationCode Code { get; set;}
        /// <summary> Estado actual del equipo. </summary>
        public Estado_equipo Estado { get; private set; } = Estado_equipo.Idle;
        /// <summary> Operaciones que puede ejecutar. </summary>
        public List<Operation> Operations { get; private set; }
        /// <summary> Variables asociadas al proceso. </summary>
        public List<Variable> Variables { get; } = new();
        /// <summary> Operación activa, <see langword="null"/> si no hay ninguna activa. </summary>
        public Operation? ActiveOperation { get; private set; } = null;
        #endregion
    
        #region Métodos
         public Unidad(Guid id,string name,UnitIdentificationCode code): base(id)
         {
         Name = name;
         Code = code;
         }
        /// <summary>
        /// Inicia la ejecución de una operación en la unidad.
        /// </summary>
        /// <param name="operation"></param>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        public Result StartOperation(Operation operation)
        {
            var result = CheckRules(
                new UnitCannotExecuteExternalOperation(operation, Operations),
                new UnitCannotExecuteOperationIfNotInIdleState(Estado));
            if (result.IsFailed)
                return result;

            ActiveOperation = operation;
            Estado = Estado_equipo.Executing;
            return Result.Ok();
        }

        /// <summary>
        /// Detiene la ejecución de una operación.
        /// </summary>
        /// <exception cref="InvalidOperationException"></exception>
        public Result StopOperation()
        {
            var result = CheckRules(
              new UnitCannotStopOperationIfItsNotExecutingAny(Estado));
            if (result.IsFailed)
                return result;

            Estado = Estado_equipo.Idle;
            ActiveOperation = null;
            return Result.Ok();
        }

        /// <summary>
        /// Lleva al equipo a un estado de falla.
        /// </summary>
        /// <exception cref="InvalidOperationException"></exception>
        public Result GetIntoFaultState()
        {
            var result = CheckRules(
               new EquipmentCannotGoIntoFaultStateIfIsAlreadyOnIt(Estado));
            if (result.IsFailed)
                return result;

            if (Estado == Estado_equipo.Executing)
                StopOperation();

            Estado = Estado_equipo.Faulted;
            return Result.Ok();
        }

        /// <summary>
        /// Saca el equipo de estado de falla.
        /// </summary>
        /// <exception cref="InvalidOperationException"></exception>
        public Result GetOutOfFaultState()
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