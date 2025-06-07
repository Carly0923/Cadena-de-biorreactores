using Dominio_Fermentación.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentResults;
using Dominio_Fermentación.Errors;
using System.Text.RegularExpressions;

///Esto debo arreglarlo
namespace Dominio_Fermentación.Rules
{
  public record CodeMustHaveSeparators (string valor) : Bussiness_Rules
  {
   public Result CheckRule()
   {
     if (!valor.Contains("-"))
        return Result.Fail(UnitIdentificationCodeErrors.CodeDoesNotHaveSeparator);
            
     return Result.Ok ();
   }
        public record CodeMustStartWithLetters(
        string Value)
        : Bussiness_Rules
        {
            public Result CheckRule()
            {
                if (!Regex.IsMatch(Value.Split('-')[0], @"^[a-zA-Z]+$"))
                    return Result.Fail(UnitIdentificationCodeErrors.CodeDoesNotStartsWithLetters);
                return Result.Ok();
            }
        }

        public record CodeMustEndWithNumbers(
            string Value)
            : Bussiness_Rules
        {
            public Result CheckRule()
            {
                if (int.TryParse(Value.Split('-')[0], out int result))
                    return Result.Fail(UnitIdentificationCodeErrors.CodeDoesNotEndsWithNumbers);
                return Result.Ok();
            }
        }


    }

}