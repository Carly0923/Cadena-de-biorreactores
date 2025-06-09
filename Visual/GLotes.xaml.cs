using System;
using System.Collections.Generic;
using System.Linq;
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
        public GLotes()
        {
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
            MessageBox.Show("No esta implementado");

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

    }
}
