using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio_Fermentación.Types
{
  public enum unidades_medida_mostradas
  {
   #region
   /// temperatura en grados celsius
   grados_Celsius,
   /// pH 0 a 14
   pH_level,
   /// porcentaje de oxígeno disuelto
   por_ciento,
   /// nivel en litros
   litros,
   /// presión en Pascal
   Pa,
   /// peso húmedo en gramos/litro
   gramos_por_litro,
   /// velocidad de agitación en revoluciones por minuto
   revoluciones_por_minuto,
   #endregion
  }
}
