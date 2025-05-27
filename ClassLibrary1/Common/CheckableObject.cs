using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentResults;

namespace Dominio_Fermentación.Common
{
    public abstract class CheckableObject
    {
        protected CheckableObject() { }
        protected static Result CheckRules(params IBussiness_Rules[] Rules) 
        {
            List<Result> results = new List<Result>();
            foreach (var rule in Rules)
            {
              results.Add(rule.CheckRule());
            }
            return Result.Merge(results.ToArray());
        }
    
     


    }
}
    
