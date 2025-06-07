using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio_Fermentación.Entities;

namespace Dominio_Fermentación.Types
{
  public enum unidades_medida_mostradas
  {
   #region
   /// <summary> temperatura en grados celsius </summary>
   grados_Celsius,
   /// <summary> nivel de pH de 0 a 14 </summary>
   pH_level,
   /// <summary> porcentaje de oxígeno disuelto </summary>
   por_ciento,
   /// <summary> nivel en litros </summary>
   litros,
   /// <summary> presión en Pascal </summary>
   Pa,
   /// <summary> peso húmedo en gramos/litro </summary>
   gramos_por_litro,
   /// <summary> velocidad de agitación en revoluciones por minuto </summary>
   revoluciones_por_minuto,
   #endregion
  }
}
