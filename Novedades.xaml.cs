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
            Name = "Sara",
            Image = "manwhite.png",


        });
        Estadoss.Add(new Estados
        {
            Name = "Andrea",
            Image = "manwhite.png",


        });
        Estadoss.Add(new Estados
        {
            Name = "Luis",
            Image = "manwhite.png",


        });
        Estadoss.Add(new Estados
        {
            Name = "Carlos",
            Image = "manwhite.png",


        });
        Estadoss.Add(new Estados
        {
            Name = "Brayan",
            Image = "manwhite.png",


        });

        Estadoss.Add(new Estados
        {
            Name = "James",
            Image = "manwhite.png",


        });


        Collection.ItemsSource = Estadoss;

        // CANALES


        Canales1.Add(new Canales
        {
            Nombre = "Real Madrid F.C",
            Imagen1 = "eeal.png",
            Actualizacion = "12:47 p.m.",
            Mensaje = "Vamos Por la 16",


        });

        Canales1.Add(new Canales
        {
            Nombre = "Red Bull",
            Imagen1 = "redbull.jpg",
            Actualizacion = "06:22 a.m.",
            Mensaje = "Compra mas red bull",


        });


        Canales1.Add(new Canales
        {
            Nombre = "Netflix",
            Imagen1 = "netflix.png",
            Actualizacion = "03:20 a.m.",
            Mensaje = "Nueva Serie",



        });

        Canales1.Add(new Canales
        {
            Nombre = "FC Barcelona",
            Imagen1 = "baarcelona.jpg",
            Actualizacion = "11:41 a.m.",
            Mensaje = "Esta Champions es la nuestra",



        });

        Canales1.Add(new Canales
        {
            Nombre = "Liverpool",
            Imagen1 = "iiverpool.jpg",
            Actualizacion = "03:22 p.m.",
            Mensaje = "Gol de Luis Diaz",

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