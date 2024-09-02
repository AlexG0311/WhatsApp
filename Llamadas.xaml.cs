using WhastApp.Model;
using System.Collections.ObjectModel;
namespace WhastApp;
public partial class Llamadas : ContentPage
{

    public ObservableCollection<MLlamadas> Llamadass { get; set; }

    public Llamadas()
	{
		InitializeComponent();

        Llamadass = new ObservableCollection<MLlamadas>();

        Llamadass.Add(new MLlamadas
        {
            Nombre = "claro",
            Imagen = "manwhite.png",
            Fecha = "Ayer, 5:58 p.m.",
            IconoDireccionLlamada = "flecha.png",
            IconoTipoLlamada = "telefono.png"


        });

        Llamadass.Add(new MLlamadas
        {
            Nombre = "tigo",
            Imagen = "manwhite.png",
            Fecha = "Ayer, 1:48 p.m.",
            IconoDireccionLlamada = "flecha.png",
            IconoTipoLlamada = "video.png"


        });

        LlamadasCollection.ItemsSource = Llamadass;
    }


    private async void OnSwiped(object sender, SwipedEventArgs e)
    {
        if (e.Direction == SwipeDirection.Right)
        {
            // Navegar a la página de Comunidades
            await Shell.Current.GoToAsync("//Comunidades");
        }
        // No hacer nada si el deslizamiento es hacia la izquierda
    }

}