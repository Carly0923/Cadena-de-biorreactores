using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio_Fermentación.Types
{
  public enum Etapa_Proceso
  {
   #region
   /// <summary> El proceso no ha iniciado aún
   /// El reactor de 75 litros se inocula primero con un psiphon de 5 litros con las muestras de la levadura </summary>
   Etapa_0,
   /// <summary> Etapa 1: Crecimiento en el tanque de 75 litros </summary>
   Etapa_1,
   /// <summary> Etapa 2: Inoculación del tanque de 75 litros al tanque de 300 litros
   /// Crecimiento en el biorreactor de 300 litros </summary>
   Etapa_2,
   /// <summary> Etapa 3: Inoculación del biorreactor de 300 litros al biorreactor de 3000 litros
   /// Crecimiento en el biorreactor de 3000 litros </summary>
   Etapa_3,
   /// <summary> Etapa 4: Terminar proceso de fermentacion
   /// Terminación final </summary>
   Etapa_4,
   #endregion
  }
}
