using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio_Fermentación.Types;
using Dominio_Fermentación.Entities.Abstract;

namespace Dominio_Fermentación.Entities
{
  public class Fermentador
  {
   #region
   /// <summary> identificador del fermentador, elemento que no puede ser NULL </summary>
   public Id_unidad ID_Fermentador { get; set; }
   /// <summary> Enumerado para el volumen de trabajo útil del fermentador </summary>
   public volumen_trabajo_util Volumen { get; set; } = volumen_trabajo_util.V75L;
   /// <summary> Etapa de crecimiento microbiano </summary>
   public etapa_crecimiento_microbiano Etapa_Fermentador { get; set; } = etapa_crecimiento_microbiano.Adaptacion;
   
   #endregion
   /// Métodos
   /// <summary> Constructor Fermentador </summary>
    public Fermentador(Id_unidad id_fermentador)
    {
     ID_Fermentador = id_fermentador;
    }
  }
}
