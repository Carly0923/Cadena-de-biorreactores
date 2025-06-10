using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Visual
{
    /// <summary>
    /// Lógica de interacción para GLotes.xaml
    /// </summary>
    public partial class GLotes : Window
    {
        public List<Lotes> lotes { set; get; }


        public GLotes()
        {
            
            lotes = new List<Lotes>()
            {
                new Lotes(new DateTime(2023, 09, 07), new DateTime(2023, 12, 09), Visual.GLotes.Productos.RBD_Abdala, Etapas.Etapa_0),
                new Lotes(new DateTime(2023, 09, 17), new DateTime(2023, 12, 19), Visual.GLotes.Productos.Heberviobac_Hepatitis_B, Etapas.Etapa_3),
                new Lotes(new DateTime(2023, 09, 27), new DateTime(2023, 12, 29), Visual.GLotes.Productos.RBD_Abdala, Etapas.Etapa_2),
                
            };

            DataContext = this;
            InitializeComponent();
        }


        #region Enumerados

        public enum Productos { RBD_Abdala, Heberviobac_Hepatitis_B }
         
        public enum Etapas { Etapa_0,Etapa_1,Etapa_2,Etapa_3,Etapa_4 }

        #endregion

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

            public Lotes( DateTime ID, DateTime FD, Productos Pro, Etapas Eta) 
            {
                _initial_date = ID;
                _final_date = FD;
                _producto= Pro;
                _etapa= Eta;
            
            }

            public event PropertyChangedEventHandler? PropertyChanged;

            public override string ToString()
            {
                return $"Producto: { Producto }, { Etapa }" ;
            }

        }




        //Boton para retroceder a la vantana principal
        private void MW(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();

        }


        //Boton para añadir lote
        private void AL(object sender, RoutedEventArgs e)
        {
            ALote.Visibility = Visibility.Visible;
            //MessageBox.Show("No esta implementado");

        }

        //Boton para quitar lote
        private void QL(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("No esta implementado");

        }

        //Boton para modificar lote
        private void ML(object sender, RoutedEventArgs e)
        {
            
            MessageBox.Show("No esta implementado");

        }

        //Boton para abrir ventana de Añadir lote
        private void A(object sender, RoutedEventArgs e)
        {
            Productos p = new Productos();
            string? a = Nproducto.Text as string;             
            
            if (a == "Abdala") 
            {
                p = Visual.GLotes.Productos.RBD_Abdala;
            }

            else if (a == "Hepatitis")
            {
                p = Visual.GLotes.Productos.Heberviobac_Hepatitis_B;
            }

            else
            {
                MessageBox.Show("Datos mal implementados");
                Nproducto.Text = null;
                NID.Text = null;
                NFD.Text = null;
                return;
            }

            
            Lotes lote = new Lotes (new DateTime (2023,09,27), new DateTime(2023,09,27),p,Etapas.Etapa_0);
            lotes.Add(lote);
            //MessageBox.Show("No esta implementado");

        }

        //Boton para cerrar ventana de Añadir lote
        private void C(object sender, RoutedEventArgs e)
        {
            ALote.Visibility= Visibility.Hidden;
            Nproducto.Text = null;
            NID.Text = null;
            NFD.Text = null;
            //MessageBox.Show("No esta implementado");
        }

    }
}
