using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio_Fermentación.Types
{
  public enum Variable_medida
  {
   #region
   /// <summary> temperatura dentro del biorreactor </summary>
   temperature,
   /// <summary> temperatura en el encamisado del biorreactor </summary>
   jacket_temperature,
   /// <summary> pH </summary>
   pH_level,
   /// <summary> nivel de oxígeno disuelto, valor dado en porcentaje </summary>
   oxigen,
   /// <summary> nivel </summary>
   level,
   /// <summary> presión </summary>
   presure,
   /// <summary> peso húmedo </summary>
   weigh_wet,
   /// <summary> velocidad de agitación </summary>
   shaking_speed,
   #endregion
  }
}
