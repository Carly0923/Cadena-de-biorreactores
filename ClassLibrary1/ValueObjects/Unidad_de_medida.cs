using Dominio_Fermentación.Types;
using Dominio_Fermentación.Common;

namespace Dominio_Fermentación.Entities
{
    public class Unidad_de_medida
     : ValueObject
    {
        #region Properties
        /// variable medida
        public Variable_medida Magnitud { get; }
        /// magnitud física
        public unidades_medida_mostradas Unidades_Medida { get; }
        #endregion

        /// <param name="Magnitud"></param>
        /// <param name="unidades_medida"></param>
        private Unidad_de_medida(){}
        public Unidad_de_medida(Variable_medida magnitud, unidades_medida_mostradas unidades_medida)
        {
            Magnitud = magnitud;
            Unidades_Medida = unidades_medida;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            return new object[] { Magnitud, Unidades_Medida };
        }
    }
}