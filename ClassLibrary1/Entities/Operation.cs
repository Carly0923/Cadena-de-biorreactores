using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio_Fermentación.Common;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dominio_Fermentación.Entities
{
    /// <summary> Modela la operación de un equipo automático. </summary>
    public class Operation
    : Entity
    {
        #region Properties
        /// <summary> Nombre de la operación. </summary>
        public string Name { get; }
        public Guid UnitId { get; }
        #endregion
        public Operation(Guid id, Guid unitId,string name) : base(id)
        {
            Name = name;
            UnitId = unitId;
        }
    }
}