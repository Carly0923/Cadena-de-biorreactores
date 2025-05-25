using Dominio_Fermentación.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentResults;

///Esto debo arreglarlo
namespace Dominio_Fermentación.Rules
{
  public record CodeMustHaveSeparators (string valor) : IBussiness_Rules
  {
   public Result CheckRule()
   {
     if (!valor.Contains("-"))
        return Result.Fail(UnitIdentificationCodeErrors.CodeDoesNotHaveSeparator);
            
     return Result.Ok ();
   }
  }
}
