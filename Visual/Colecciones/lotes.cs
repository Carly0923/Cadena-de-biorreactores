using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visual.Clases;
using Visual.Enumerados;

namespace Visual.Colecciones
{
    public class lotes : INotifyPropertyChanged
    {
        private ObservableCollection<Lotes> _alllotes;

        public lotes()
        {
            _alllotes = new ObservableCollection<Lotes>()
            {
                new Lotes(new DateTime(2023, 09, 07), new DateTime(2023, 12, 09), Productos.RBD_Abdala, Etapas.Etapa_0)
            };
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        
        public ObservableCollection<Lotes> Alllotes {
            get { return _alllotes; }
            
            set {
                _alllotes = value;
                OnPropertyChanged(nameof(Alllotes));
            }
        }

    }

}
