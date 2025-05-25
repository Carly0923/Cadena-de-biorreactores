using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Dominio_Fermentación.Common;
using Dominio_Fermentación.Rules;
using Dominio_Fermentación.Types;

namespace Dominio_Fermentación.Entities
{
    public class Id_unidad
    {
     public string Valor { get; }

     public Id_unidad(string valor)
     {
      ///Chequear el separador
       if (!valor.Contains("-"))
          throw new ArgumentException("El código de la unidad debe contener - como separador");
      /// Separar el string en dos con el separador
      var partes_codigo=valor.Split('-');
      string izquierda_parte_codigo = partes_codigo[0];
      string derecha_parte_codigo = partes_codigo[1];

      /// Chequear que la parte izquierda sea solo letras
       if (!Regex.IsMatch(izquierda_parte_codigo, @"^[a-zA-Z]+$"))
          throw new ArgumentException("La parte izquierda del código del equipo debe contoner solo letras");
      /// Chequear que la parte derecha sea solo números
       if (int.TryParse(derecha_parte_codigo, out int result))
          throw new ArgumentException("La parte derecha del código del equipo debe contoner solo números");
      Valor = valor;
     }
    }
}
