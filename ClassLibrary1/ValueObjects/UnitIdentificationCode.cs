using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio_Fermentación.Common;
using Dominio_Fermentación.Errors;
using FluentResults;
using System.Text.RegularExpressions;
using Dominio_Fermentación.Rules;
using static Dominio_Fermentación.Rules.CodeMustHaveSeparators;

namespace EquipmentMonitoring.Domain.ValueObjects
{
    /// <summary> Código de identificación de una unidad. </summary>
    public class UnitIdentificationCode
        : ValueObject
    {
        public string Value { get; }

        public UnitIdentificationCode(
            string value)
        {
         Value = value;
        }

        public static Result<UnitIdentificationCode> Create(string value)
        {
            var result = CheckRules(
                new CodeMustHaveSeparator(value));
            if (result.IsFailed)
                return result.ToResult<UnitIdentificationCode>();

            result = CheckRules(
                new CodeMustStartWithLetters(value),
                new CodeMustEndWithNumbers(value));
            if (result.IsFailed)
                return result.ToResult<UnitIdentificationCode>();

            return Result.Ok(new UnitIdentificationCode(value));
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            return new[] { Value };
        }
    }
}