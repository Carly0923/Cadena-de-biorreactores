using Dominio_Fermentación.Common;
using Dominio_Fermentación.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio_Fermentación.ValueObjects
{
    public class MeasurementUnit
     :ValueObject
    {
     #region Properties
     /// <summary> Magnitud física que representa. </summary>
     public Variable_medida PhysicalMagnitude { get; }
     /// <summary> Símbolo utilizado para la magnitud. </summary>
     public string Symbol { get; }
     #endregion

     #region Métodos
      public MeasurementUnit(Variable_medida physicalMagnitude,string symbol)
      {
       PhysicalMagnitude = physicalMagnitude;
       Symbol = symbol;
      }
      protected override IEnumerable<object> GetEqualityComponents()
      {
       return new object[] { PhysicalMagnitude, Symbol };
      }
     #endregion
    }
}