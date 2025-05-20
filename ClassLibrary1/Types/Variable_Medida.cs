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
   /// <summary> temperatura dentro del biorreactor
   temperature,
   /// <summary> temperatura en el encamisado del biorreactor
   jacket_temperature,
   /// <summary> pH
   pH_level,
   /// <summary> nivel de oxígeno disuelto, valor dado en porcentaje
   oxigen,
   /// <summary> nivel
   level,
   /// <summary> presión
   presure,
   /// <summary> peso húmedo
   weigh_wet,
   /// <summary> velocidad de agitación
   shaking_speed,
   #endregion
  }
}
