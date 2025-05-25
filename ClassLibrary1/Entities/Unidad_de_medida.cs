using Dominio_Fermentación.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio_Fermentación.Common;
using Dominio_Fermentación.Entities.Abstract;

namespace Dominio_Fermentación.Entities
{
    public class Unidad_de_medida
     : ValueObject
    {
     #region Properties
     /// variable medida
     public Variable_medida magnitud { get; }
     /// magnitud física
     public unidades_medida_mostradas Unidades_Medida { get; }
     #endregion
/// <summary>
/// Este debe ser el constructor
/// </summary>
/// <param name="Magnitud"></param>
/// <param name="unidades_medida"></param>
     public Unidad_de_medida(Variable_medida Magnitud,
                             unidades_medida_mostradas unidades_medida)
        {
            Magnitud = magnitud;
            unidades_medida = Unidades_Medida;
        }
     
      protected override IEnumerable<object> GetEqualityComponents()
      {
       return new object[] { magnitud, Unidades_Medida };
      }    
    }
}
