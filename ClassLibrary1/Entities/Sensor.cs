using Dominio_Fermentación.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio_Fermentación.Common;
using Dominio_Fermentación.Entities.Abstract;
using Dominio_Fermentación.ValueObjects;

namespace Dominio_Fermentación.Entities
{
    public class Sensor
    {
        #region Properties
        /// <summary> Id de identificación del sensor </summary>
        public UnitIdentificationCode Codesensor { get; set; }
        public string Namesensor { get; set; }
        /// <summary> tipo de sensor </summary>
        public Variable Variable_medida { get; private set; }
        /// <summary> Estado de funcionamiento del sensor </summary>
       // public Estado_equipo estado_equipo_sensor { get; set; } = Estado_equipo.Executing;
        /// <summary> variables que mide este sensor </summary>
        #endregion

        #region Methods
        /// <summary> Constructor </summary>
        public Sensor(string namesensor, UnitIdentificationCode codesensor, Variable variable_medida)
        {
            Namesensor = namesensor;
            Codesensor = codesensor;
            Variable_medida = variable_medida;
        }
        #endregion
    }
}