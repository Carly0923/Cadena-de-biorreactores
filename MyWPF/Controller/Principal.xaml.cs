using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using MyWPF;
using Dominio_Fermentación.Contracts.Repositories;
using Dominio_Fermentación.Entities;
using Dominio_Fermentación.Persistence.Context;


namespace MyWPF.View;

/// <summary>
/// Lógica de interacción para Principal.xaml
/// </summary>
public partial class Principal : Window
{
    private string _username; // Variable para almacenar el nombre de usuario
    // Constructor que recibe el nombre de usuario
    public Principal(string username)
    {
        InitializeComponent();
        _username = username; // Guardamos el nombre de usuario
        LoadLotes();
    }

    private void Lotes_Click(object sender, RoutedEventArgs e)
    {
    }

    private void LoadLotes()
    {
        //List<Movie> movies = new List<Movie>
        //{
        //        new Movie { Title = "El Joker 2", ImagePath = "C:/Users/pablo/Pictures/Cine/eljoker2.jpg" },
        //        new Movie { Title = "Gladiador 2", ImagePath = "C:/Users/pablo/Pictures/Cine/gladiator.jpg" },
        //        new Movie { Title = "Robot Salvaje", ImagePath = "C:/Users/pablo/Pictures/Cine/robot-salvaje.jpg" }
        //    };

        //MoviesListBox.ItemsSource = movies; // Asignar la lista de películas al ListBox
    }
}






