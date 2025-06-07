using FluentResults;
using Dominio_Fermentación.Types;
using Dominio_Fermentación.Common;
using Dominio_Fermentación.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio_Fermentación.Rules
{
    public record EquipmentCannotGoIntoFaultStateIfIsAlreadyOnIt(
        Estado_equipo CurrentState)
        : IBussiness_Rules
    {
        public Result CheckRule()
        {
            if (CurrentState == Estado_equipo.Faulted)
                return Result.Fail(IStatefulEquipmentErrors.EquipmentIsAlreadyFaulted);
            return Result.Ok();
        }
    }
    public record EquipmentCannotGetOutOfFaultedStateIfItsNotInIt(
        Estado_equipo CurrentState)
        : IBussiness_Rules
    {
        public Result CheckRule()
        {
            if (CurrentState != Estado_equipo.Faulted)
                return Result.Fail(IStatefulEquipmentErrors.EquipmentIsNotFaulted);
            return Result.Ok();
        }
    }
}