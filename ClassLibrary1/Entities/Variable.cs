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
   #region
   ///Número de la medición
   public float Medicion { get; set; }
   /// unidad de medida
   public unidades_medida_mostradas unidad { get; set; } = unidades_medida_mostradas.grados_Celsius;
   ///punto de comunicación
   public Comunication_Node Node { get; set; }
   #endregion
   ///Métodos
   ///Constructor
   public Variable(float number,unidades_medida_mostradas Unidad,Comunication_Node node)
   {
    Medicion = number;
    unidad = Unidad;
    Node= node;
   }
  }
}
