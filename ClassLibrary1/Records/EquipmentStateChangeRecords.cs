using Dominio_Fermentación.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio_Fermentación.Records
{
  
        /// <summary> Registro de un cambio en el estado de un equipamiento. </summary>
        /// <param name="EquipmentId"></param>
        /// <param name="OccurringTime"></param>
        /// <param name="NewState"></param>
        public record EquipmentStateChangeRecords(Guid EquipmentId, DateTime OccurringTime, Estado_equipo NewState);
    
}