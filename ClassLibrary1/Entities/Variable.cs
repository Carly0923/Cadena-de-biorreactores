using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio_Fermentación.Types;
using Dominio_Fermentación.Entities.Abstract;
using Dominio_Fermentación.Entities;

namespace Dominio_Fermentación.Entities
{
  public class Variable
  {
   #region Properties
   /// <summary> Entidad numérica que después debe ser acompañada por la unidad de medida </summary>
   public float Medicion { get; set; }
   /// <summary> La unidad de medida </summary>
   public unidades_medida_mostradas unidad { get; set; } = unidades_medida_mostradas.grados_Celsius;
   ///<summary> Punto del nodo de comunicación </summary>
   public Comunication_Node Node { get; set; }
   #endregion

   #region Metodos
   ///Constructor
   public Variable(float number,unidades_medida_mostradas Unidad,Comunication_Node node)
   {
    Medicion = number;
    unidad = Unidad;
    Node= node;
   }
   #endregion
  }
}
