using Dominio_Fermentación.Types;
using Dominio_Fermentación.Common;
using Dominio_Fermentación.Rules;
using FluentResults;
using Dominio_Fermentación.ValueObjects;

namespace Dominio_Fermentación.Entities
{
    public class Programmable_Logic_Controller
       : AutomationDevice
    {
        #region Propiedades
        /// <summary> Número de identificación del PLC </summary>
       // public Id_unidad Id_PLC { get; set; }
        /// <summary> La marca del PLC es un enumerado declarado en Types </summary>
       // public Marca_PLC marca_PLC { get; set; } = Marca_PLC.S7_300;
        /// <summary> Dirección IP </summary>
        //public Network_Address IP_Address { get; set; }
        /// <summary> Estado de funcionamiento del PLC </summary>
       // public Estado_equipo estado_equipo_PLC { get; set; } = Estado_equipo.Executing;
        #endregion
       // private Programmable_Logic_Controller() { }
        ///<summary> Constructor </summary>
        public Programmable_Logic_Controller(Guid id,  Dirección_Red address, Estado_equipo state) : base(id, address, state )
        {
            //Address = address;
            //estado_equipo_PLC = state;
        }
    }
}