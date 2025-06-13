
using Dominio_Fermentación.Common;
using Dominio_Fermentación.ValueObjects;

namespace Dominio_Fermentación.Entities
{
    public class Variable
     : Entity
    {
        #region Properties
        /// <summary> Entidad numérica que después debe ser acompañada por la unidad de medida </summary>
        public Guid UnitId { get; }
        public string Medicion { get; set; }
        /// <summary> La unidad de medida </summary>
        public Unidad_de_medida Unidad { get; set; }
        ///<summary> Punto del nodo de comunicación </summary>
        public Nodo_Comunicación Node { get; set; }
        #endregion
        protected Variable() { }
        #region Metodos
        ///Constructor
        public Variable(Guid id, Guid unitId,string number, Unidad_de_medida unidad, Nodo_Comunicación node) : base(id)
        {
            UnitId = unitId;
            Medicion = number;
            Unidad = unidad;
            Node = node;
        }
        #endregion
    }
}