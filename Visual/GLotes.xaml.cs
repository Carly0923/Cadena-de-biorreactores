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
using Visual.Clases;
using Visual.Enumerados;
using Visual.Colecciones;
using System.ComponentModel.DataAnnotations;

namespace Visual
{
    /// <summary>
    /// Lógica de interacción para GLotes.xaml
    /// </summary>
    public partial class GLotes : Window
    {

        
        public lotes lots { set; get; }


        public GLotes()
        {         
            lots= new lotes();
            DataContext = this;
            InitializeComponent();
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
            propiesdades.Visibility = Visibility.Hidden;
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
            
            if (Nproducto.Text == "Abdala") 
            {
                p = Productos.RBD_Abdala;
            }

            else if (Nproducto.Text == "Hepatitis")
            {
                p = Productos.Heberviobac_Hepatitis_B;
            }

            else
            {
                MessageBox.Show("Datos mal implementados");
                Nproducto.Text = null;
                NID.Text = null;
                NFD.Text = null;
                return;
            } 

            
            Lotes lote = new Lotes (new DateTime (2025,05,10), new DateTime(2025,10,10),p,Etapas.Etapa_0);
            lots.Alllotes.Add(lote);
            Nproducto.Text = null;
            NID.Text = null;
            NFD.Text = null;
            ALote.Visibility = Visibility.Hidden;
            propiesdades.Visibility = Visibility.Visible;
            MessageBox.Show("Se ha agregado un nuevo lote");
            //MessageBox.Show("No esta implementado");

        }

        //Boton para cerrar ventana de Añadir lote
        private void C(object sender, RoutedEventArgs e)
        {
            propiesdades.Visibility=Visibility.Visible;
            ALote.Visibility= Visibility.Hidden;
            Nproducto.Text = null;
            NID.Text = null;
            NFD.Text = null;
            //MessageBox.Show("No esta implementado");
        }

        private void ListView_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Hola");
            //TID.Text =loteslist
            //TFD.Text = loteslist.SelectedItem.
        }
    }
}
