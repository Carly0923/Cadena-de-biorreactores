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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Visual
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// Variable booleana para saber si hay un usuario autenticado
        bool Autent = false;

        ///Boton para abrir la ventana de gestión de usuarios
        private void GU(object sender, RoutedEventArgs e)
        {
            if (Autent)
            {
                //MessageBox.Show("Gestión de Usuarios");
                GUsuarios gUsuarios = new GUsuarios();
                this.Close();
                gUsuarios.Show();
            }

            else
            {
                MessageBox.Show("Debes autenticarte");
            }
        }

        /// Boton para abrir la pantalla de gestión de lotes
        private void GL(object sender, RoutedEventArgs e)
        {

            if (Autent)
            {
                //MessageBox.Show("Gestión de Lotes");
                GLotes gLotes = new GLotes();
                this.Hide();
                gLotes.Show();

            }

            else
            {
                MessageBox.Show("Debes autenticarte");
            }

        }

        /// Boton para iniciar y cerrar sesión
        private void IS(object sender, RoutedEventArgs e)
        {
            if (Autent == false)
            {

                MessageBox.Show("Has iniciado sesión correctamente");
                LoginButton.Content = "Cerrar Sesión";
                Autent = true;

            }

            else
            {
                MessageBox.Show("Has cerrdo sesión correctamente");
                LoginButton.Content = "Iniciar Sesión";
                Autent = false;

            }

        }

    }
}
