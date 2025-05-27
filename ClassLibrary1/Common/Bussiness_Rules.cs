using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentResults;

namespace Dominio_Fermentación.Common
{
   public interface IBussiness_Rules
   {
        Result CheckRule();  
   }
}
