using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio_Fermentación.Common;
using Dominio_Fermentación.Types;


namespace Dominio_Fermentación.Entities
{
  public class Batch
   :Entity
  {
   #region Propiedades
   /// <summary> Identificador del lote producido </summary>
   public Id_unidad Id_Batch { get; set; }
   /// <summary> Fecha de Inicio </summary>
   public DateTime? Initial_Date { get; set; }
   /// <summary> Fecha de Finalización del lote </summary>
   public DateTime? Final_Date { get; set; }
   /// <summary> Producto en fermentación enumerado guradado en Types </summary>
   public Sustancias_Producto producto { get; set; } = Sustancias_Producto.Heberviobac_Hepatitis_B;
   /// <summary> Etapa fermentación, comienza con la inoculacion de 5 a 75 litros </summary>
   public Etapa_Proceso Etapa_Proceso { get; set; } = Etapa_Proceso.Etapa_0;
   #endregion
   /// Métodos
   /// Constructor
    public Batch(Id_unidad id_batch, DateTime inicio, DateTime final, Guid id) : base(id)
    {
     #region 
     Id_Batch = id_batch;
     Initial_Date = inicio;
     Final_Date = final;
     #endregion
    }
  }
}
