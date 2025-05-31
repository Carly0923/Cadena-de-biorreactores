using Dominio_Fermentación.Entities;
using Dominio_Fermentación.Errors;
using Dominio_Fermentación.Common;
using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio_Fermentación.Types;

namespace Dominio_Fermentación.Rules
{

    public record UnitCannotExecuteExternalOperation(
       Operation TargetOperation,
       IEnumerable<Operation> InternalOperations)
       : IBusinessRule
    {
        public Result CheckRule()
        {
            if (!InternalOperations.Contains(TargetOperation))
                return Result.Fail(UnitErrors.CannotExecuteExternalOperation);
            return Result.Ok();
        }
    }

    public record UnitCannotExecuteOperationIfNotInIdleState(
        EquipmentState CurrentState)
       : IBusinessRule
    {
        public Result CheckRule()
        {
            if (CurrentState != EquipmentState.Idle)
                return Result.Fail(UnitErrors.CannotExecuteOperationIfNotIdle);
            return Result.Ok();
        }
    }

    public record UnitCannotStopOperationIfItsNotExecutingAny(
        EquipmentState CurrentState)
       : IBusinessRule
    {
        public Result CheckRule()
        {
            if (CurrentState != EquipmentState.Executing)
                return Result.Fail(UnitErrors.CannotStopIfNotExecuting);
            return Result.Ok();
        }
    }
}