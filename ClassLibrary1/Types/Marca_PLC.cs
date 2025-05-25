using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio_Fermentación.Common;
using Dominio_Fermentación.Entities.Abstract;
using Dominio_Fermentación.Rules;
namespace Dominio_Fermentación.Types
{
  public enum Marca_PLC
  {
   #region
   /// Siemens S7-300
   S7_300,
   /// Siemens S7-400
   S7_400,
   /// Siemens s7-1200
   S7_1200,
   /// Siemens s7_1500
   S7_1500,
   /// Mitsubishi
   Mitsubishi,
   /// Unitronics
   Unitronics,
   /// Schneider-electric
   Schneider,
   /// Omrom
   Omrom,
   #endregion
  }
}
