using Dominio_Fermentación.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio_Fermentación.Entities.Abstract;

namespace Dominio_Fermentación.Entities
{
  public class Programmable_Logic_Controller
  {
   #region Propiedades
   /// <summary> Número de identificación del PLC </summary>
   public Id_unidad Id_PLC { get; set; }
   /// <summary> La marca del PLC es un enumerado declarado en Types </summary>
   public Marca_PLC marca_PLC { get; set; } = Marca_PLC.S7_300;
   /// <summary> Dirección IP </summary>
   public string IP_Address { get; set; }
   /// <summary> Estado de funcionamiento del PLC </summary>
   public Estado_equipo estado_equipo_PLC { get; set; } = Estado_equipo.Executing;
   #endregion
   ///<summary> Constructor </summary>
    public Programmable_Logic_Controller(Id_unidad id_number, string ip_address)
    {
     Id_PLC = id_number;
     IP_Address = ip_address;
    }
  }
}
