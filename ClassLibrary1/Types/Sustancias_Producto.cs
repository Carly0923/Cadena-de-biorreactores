using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio_Fermentación.Types
{
  public enum Sustancias_Producto
  {
   #region
   /// <summary> Receptor Binding Domain para la vacuna Abdala
   /// Usa la levadura Pichia Pastoris, decodifica ambos genes AOX1 y AOX2 que metabolizan el alcohol oxidasa y sus derivados
   /// Ocurren cambios en la fuente de carbono de glicerol a metanol </summary>
   RBD_Abdala,
   /// <summary> Heberviobac, vacuna contra la hepatitis B
   /// Usa también la levadura Pichia Pastoris, decodifina solo el gen AOX1, no hay cambios en la fuente de carbono
   /// Solo utiliza glicerol </summary>
   Heberviobac_Hepatitis,
   #endregion
  }
}
