using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Visual.GLotes;
using Visual.Enumerados;

namespace Visual.Clases
{
    public class Lotes : INotifyPropertyChanged
    {
        #region Fecha_Inicial
        private DateTime? _initial_date;

        public DateTime? Initial_date
        {
            get
            {
                return _initial_date;
            }

            set
            {
                if (_initial_date == null)
                    return;

                _initial_date = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Fecha Inicial"));

            }
        }

        #endregion

        #region Fecha_Final
        private DateTime? _final_date;

        public DateTime? Final_date
        {
            get
            {
                return _final_date;
            }

            set
            {
                if (_final_date == null)
                    return;

                _final_date = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Fecha Final"));

            }
        }

        #endregion

        #region Productos
        private Productos _producto;

        public Productos Producto
        {
            get
            {
                return _producto;
            }

            set
            {
                if (_producto == null)
                    return;

                _producto = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Producto"));

            }
        }
        #endregion

        #region Etapa
        private Etapas _etapa;
        public Etapas Etapa
        {
            get
            {
                return _etapa;
            }

            set
            {
                if (_etapa == null)
                    return;

                _etapa = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Etapa"));

            }
        }

        #endregion

        public Lotes(DateTime ID, DateTime FD, Productos Pro, Etapas Eta)
        {
            _initial_date = ID;
            _final_date = FD;
            _producto = Pro;
            _etapa = Eta;

        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public override string ToString()
        {
            return $"Producto: {Producto}, {Etapa}";
        }

    }
}
