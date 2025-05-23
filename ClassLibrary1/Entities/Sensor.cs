﻿using Dominio_Fermentación.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace Dominio_Fermentación.Entities
 {
   public class Sensor
   {
    #region Properties
    /// <summary> Id de identificación del sensor </summary>
    public Id_unidad Id_sensor { get; set; }
    /// <summary> tipo de sensor </summary>
    public Variable_medida variable_medida { get; private set; } = Variable_medida.temperature;
    /// <summary> Estado de funcionamiento del sensor </summary>
    public Estado_equipo estado_equipo_sensor { get; set; } = Estado_equipo.Executing;
    /// <summary> variables que mide este sensor </summary>
    public List<Variable> Variables { get; private set; }
    #endregion
    /// <summary> Constructor </summary>
     public Sensor(Id_unidad id_number)
     {
      Id_sensor = id_number;
     }
   }
 }
