namespace WhastApp;

using System.Collections.ObjectModel;
using WhastApp.Model;
public partial class Novedades : ContentPage
{
    public ObservableCollection<Estados> Estadoss { get; set; }
    public ObservableCollection<Canales> Canaless { get; set; }

    public ObservableCollection<Canales> Canales1 { get; set; }


    public Novedades()
	{

		InitializeComponent();

        Estadoss = new ObservableCollection<Estados>();

        Canaless = new ObservableCollection<Canales>();


        Canales1 = new ObservableCollection<Canales>();

        Estadoss.Add(new Estados
        {
            Name = "Estad",
            Image = "manwhite.png",


        });
        Estadoss.Add(new Estados
        {
            Name = "Estado1",
            Image = "manwhite.png",


        });
        Estadoss.Add(new Estados
        {
            Name = "Estado2",
            Image = "manwhite.png",


        });
        Estadoss.Add(new Estados
        {
            Name = "Estado3",
            Image = "manwhite.png",


        });
        Estadoss.Add(new Estados
        {
            Name = "Estado3",
            Image = "manwhite.png",


        });

        Estadoss.Add(new Estados
        {
            Name = "Estado3",
            Image = "manwhite.png",


        });


        Collection.ItemsSource = Estadoss;

        // CANALES


        Canales1.Add(new Canales
        {
            Nombre = "Pepito1",
            Imagen1 = "manwhite.png",
            Actualizacion = "",
            Mensaje = "Hola",


        });

        Canales1.Add(new Canales
        {
            Nombre = "Pepito1",
            Imagen1 = "manwhite.png",
            Actualizacion = "",
            Mensaje = "Hola",


        });


        Canales1.Add(new Canales
        {
            Nombre = "Pepito1",
            Imagen1 = "manwhite.png",
            Actualizacion = "",
            Mensaje = "Hola",



        });

        Canales1.Add(new Canales
        {
            Nombre = "Pepito1",
            Imagen1 = "manwhite.png",
            Actualizacion = "",
            Mensaje = "Hola",



        });

        Canales1.Add(new Canales
        {
            Nombre = "Pepito1",
            Imagen1 = "manwhite.png",
            Actualizacion = "",
            Mensaje = "Hola",



        });

        canales1.ItemsSource = Canales1;


        // BUSCAR CANALES


        Canaless.Add(new Canales
        {
            Nombre = "Pepito1",
            Imagen = "manwhite.png",


        });


        Canaless.Add(new Canales
        {
            Nombre = "Pepito2",
            Imagen = "manwhite.png",


        });


        Canaless.Add(new Canales
        {
            Nombre = "Pepito3",
            Imagen = "manwhite.png",


        });

        Canaless.Add(new Canales
        {
            Nombre = "Pepito4",
            Imagen = "manwhite.png",


        });


        Canaless.Add(new Canales
        {
            Nombre = "Pepito5",
            Imagen = "manwhite.png",


        });

        Canaless.Add(new Canales
        {
            Nombre = "Pepito6",
            Imagen = "manwhite.png",


        });


        Canaless.Add(new Canales
        {
            Nombre = "Pepito7",
            Imagen = "manwhite.png",


        });

        Canales.ItemsSource = Canaless;

    }


    private async void OnSwiped(object sender, SwipedEventArgs e)
    {
        if (e.Direction == SwipeDirection.Left)
        {
            // Navegar a la página de Comunidades
            await Shell.Current.GoToAsync("//Comunidades");
        }
        else if (e.Direction == SwipeDirection.Right)
        {
            // Volver a la página de Chats
            await Shell.Current.GoToAsync("//Chats");
        }
    }

}