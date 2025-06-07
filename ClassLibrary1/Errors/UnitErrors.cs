using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio_Fermentación.Errors
{
    internal class UnitErrors
    {
     public static Error CannotExecuteExternalOperation =>
        new Error("Cannot execute external operation to this unit.");

     public static Error CannotExecuteOperationIfNotIdle =>
        new Error("Cannot execute operation if unit is not idle.");

     public static Error CannotStopIfNotExecuting =>
        new Error("Cannot stop operation if unit is not executing any.");
    }
}
