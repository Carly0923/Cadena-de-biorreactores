using Dominio_Fermentación.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio_Fermentación.Entities.Abstract
{
  public interface IStateful_Equipment
  { 
   Estado_equipo Estado { get; }
    void GetintoFault();
    void GetoutFault();
  }
}
