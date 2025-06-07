using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio_Fermentación.Common
{
  public abstract class Entity
   :CheckableObject
  {
   #region Properties
   public Guid Id { get; set; }
   #endregion
   protected Entity(Guid id)
   {
    Id = id;
   }
  }
  
}
