﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio_Fermentación.Types
{
  /// <summary> Enumera los posibles estados de funcionamiento de los equipos. Se la copié a Hernan jajaja.
  public enum Estado_equipo
  {
   #region
   /// <summary> En espera de ejecución.
   Idle,
   /// <summary> En ejecución.
   Executing,
   /// <summary> En estado de fallo.
   Faulted
   #endregion
  }
}
