using System.Windows;
using MyWPF.View;

namespace MyWPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // MainWindow.xaml.cs
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();
            this.Close();
        }


        //private void RegisterButton_Click(object sender, RoutedEventArgs e)
        //{
        //    RegisterWindow registerWindow = new RegisterWindow();
        //    registerWindow.ShowDialog();
        //}
    }
}
