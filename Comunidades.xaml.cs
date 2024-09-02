using Microsoft.VisualBasic;
using System.Collections.ObjectModel;
using WhastApp.Model;

namespace WhastApp;
public partial class Comunidades : ContentPage
{


    public Comunidades()
    {
        InitializeComponent();

    }

    private async void OnSwiped(object sender, SwipedEventArgs e)
    {
        if (e.Direction == SwipeDirection.Left)
        {
            // Navegar a la página de Comunidades
            await Shell.Current.GoToAsync("//Llamadas");
        }
        else if (e.Direction == SwipeDirection.Right)
        {
            // Volver a la página de Chats
            await Shell.Current.GoToAsync("//Novedades");
        }

    }
}
