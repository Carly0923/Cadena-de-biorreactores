using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio_Fermentación.Types;
using Dominio_Fermentación.Entities.Abstract;
using Dominio_Fermentación.Entities;
using Dominio_Fermentación.Common;
using Dominio_Fermentación.ValueObjects;

namespace Dominio_Fermentación.Entities
{
    public class Variable
     : Entity
    {
        #region Properties
        /// <summary> Entidad numérica que después debe ser acompañada por la unidad de medida </summary>
        public float Medicion { get; set; }
        /// <summary> La unidad de medida </summary>
        public Unidad_de_medida unidad { get; set; }
        ///<summary> Punto del nodo de comunicación </summary>
        public Nodo_Comunicación Node { get; set; }
        #endregion

        #region Metodos
        ///Constructor
        public Variable(Guid id, float number, Unidad_de_medida Unidad, Nodo_Comunicación node) : base(id)
        {
            Medicion = number;
            unidad = Unidad;
            Node = node;
        }
        #endregion
    }
}