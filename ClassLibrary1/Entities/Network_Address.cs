using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio_Fermentación.Entities
{
 internal class Network_Address
 {
  #region Propiedades
  /// Dirección IP
  public string Direccion_IP { get; }
  /// Puerto
  public int Direccion_Puerto { get;}
  #endregion

  #region Métodos
  public Network_Address(string direccion_IP, int direccion_Puerto) 
  {
   var ipParticionado=direccion_IP.Split('.');
        if (ipParticionado.Count() == 4)
            throw new ArgumentException("Dirección IP inválida.");
       foreach (var part in ipParticionado)
       {
          if (!int.TryParse(part, out int partNumber))
              throw new ArgumentException("Dirección IP inválida.");
          if (partNumber < 0 || partNumber > 255)
              throw new ArgumentException("Dirección IP inválida.");
       }
            if (direccion_Puerto < 1023 || direccion_Puerto > 65535)
                throw new ArgumentException("Dirección de puerto inválida.");
   
   Direccion_IP= direccion_IP;
   Direccion_Puerto= direccion_Puerto;
  }
  #endregion
 }
}
