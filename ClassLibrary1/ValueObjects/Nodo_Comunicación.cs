using Dominio_Fermentación.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio_Fermentación.ValueObjects
{
    /// <summary> Modela un punto de comunicación ModbusTCP. </summary>
    public class Nodo_Comunicación
     : ValueObject
    {
        #region Properties
        /// <summary> Posición del registro inicial a leer. </summary>
        public int RegisterPosition { get; }
        ///  <summary> Cantidad de registros a leer a partir del inicial. </summary>
        public int RegisterLength { get; }
        #endregion
        private Nodo_Comunicación() { }
       
        public Nodo_Comunicación(int registerPosition, int registerLength)
        {
            RegisterPosition = registerPosition;
            RegisterLength = registerLength;
        }
        protected override IEnumerable<object> GetEqualityComponents()
        {
            return new object[] { RegisterPosition, RegisterLength };
        }
    }
}