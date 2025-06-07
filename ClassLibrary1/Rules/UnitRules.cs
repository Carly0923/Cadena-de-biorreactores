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
    ///Arreglar y agregar luego Operationy UnitErrors
    public record UnitCannotExecuteExternalOperation(
       Operation TargetOperation,
       IEnumerable<Operation> InternalOperations)
       : IBussiness_Rules
    {
        public Result CheckRule()
        {
            if (!InternalOperations.Contains(TargetOperation))
                return Result.Fail(UnitErrors.CannotExecuteExternalOperation);
            return Result.Ok();
        }
    }

    public record UnitCannotExecuteOperationIfNotInIdleState(
        Estado_equipo CurrentState)
       : IBussiness_Rules
    {
        public Result CheckRule()
        {
            if (CurrentState != Estado_equipo.Idle)
                return Result.Fail(UnitErrors.CannotExecuteOperationIfNotIdle);
            return Result.Ok();
        }
    }

    public record UnitCannotStopOperationIfItsNotExecutingAny(
        Estado_equipo CurrentState)
       : IBussiness_Rules
    {
        public Result CheckRule()
        {
            if (CurrentState != Estado_equipo.Executing)
                return Result.Fail(UnitErrors.CannotStopIfNotExecuting);
            return Result.Ok();
        }
    }
}