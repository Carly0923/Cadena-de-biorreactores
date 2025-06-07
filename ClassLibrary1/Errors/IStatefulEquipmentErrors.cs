using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio_Fermentación.Errors
{
    public static class IStatefulEquipmentErrors
    {
        public static Error EquipmentIsAlreadyFaulted =>
            new Error("Equipment is already in faulted state.");

        public static Error EquipmentIsNotFaulted =>
            new Error("Equipment is not in faulted state.");
    }
}