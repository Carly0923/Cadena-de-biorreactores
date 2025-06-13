using Dominio_Fermentación.Common;
using Dominio_Fermentación.Types;
using Dominio_Fermentación.Entities.Abstract;
using Dominio_Fermentación.Errors;
using Dominio_Fermentación.Rules;
using FluentResults;
using Microsoft.VisualBasic;
using Dominio_Fermentación.ValueObjects;
using Dominio_Fermentación.Entities;


namespace Dominio_Fermentación.Entities
{
    public class Batch
     : Entity
    {
        #region Propiedades
        /// <summary> Identificador del lote producido </summary>
        public UnitIdentificationCode Codelote { get; set; }
        public Guid UnitId { get; }
        //  public Id_unidad Id_Batch { get; set; }
        /// <summary> Fecha de Inicio </summary>
        public string Namelote { get; set; }
        public DateTime Initial_Date { get; set; }
        /// <summary> Fecha de Finalización del lote </summary>
        public DateTime Final_Date { get; set; }
        /// <summary> Producto en fermentación enumerado guradado en Types </summary>
        public Sustancias_Producto producto { get; set; } = Sustancias_Producto.Heberviobac_Hepatitis_B;
        /// <summary> Etapa fermentación, comienza con la inoculacion de 5 a 75 litros </summary>
        public Etapa_Proceso Etapa_Proceso { get; set; } = Etapa_Proceso.Etapa_0;
      
        #endregion
        /// Métodos
        /// Constructor
       #region 
        protected Batch()
        {
        
        }
        public Batch(Guid id, Guid unitId, string namelote, UnitIdentificationCode codelote, DateTime inicio, DateTime final) : base(id)
        {
            
            Namelote = namelote;
            UnitId = unitId;
            Codelote = codelote;
            Initial_Date = inicio;
            Final_Date = final;

        }
       #endregion
    }
}