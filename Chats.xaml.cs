using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;
using WhastApp.Model;

namespace WhastApp
{
    public partial class Chats : ContentPage
    {
        public ObservableCollection<ModelChats> ModelChat { get; set; }

        public Chats()
        {
            InitializeComponent();

            // Inicializa la colección de chats
            ModelChat = new ObservableCollection<ModelChats>
            {
                new ModelChats
                {
                    Nombre = "Alex",
                    UltimoMensaje = "ok",
                    Hora = "12:09 a. m.",
                    Imagen = "manwhite.png",
                    remitente = "Hola Amigo como estas",
                    usuario ="Bien y tu mano"

                },
                new ModelChats
                {
                    Nombre = "Camilo",
                    UltimoMensaje = "Actividad2Movil.rar",
                    Hora = "12:01 a. m.",
                    Imagen = "manwhite.png",
                    remitente = "Hola camilo",
                    usuario ="Hola"

                },
                new ModelChats
                {
                    Nombre = "Sebas",
                    UltimoMensaje = "......",
                    Hora = "Ayer",
                    Imagen = "manwhite.png",
                    remitente = "Hola Amigo como estas",
                    usuario ="Bien y tu mano"

                },
                new ModelChats
                {
                    Nombre = "Luis",
                    UltimoMensaje = ".......",
                    Hora = "Ayer",
                    Imagen = "manwhite.png",
                    remitente = "Hola Amigo como estas",
                    usuario ="Bien y tu mano"

                },
                new ModelChats
                {
                    Nombre = "Sofia",
                    UltimoMensaje = "bueno",
                    Hora = "Ayer",
                    Imagen = "manwhite.png",
                    remitente = "Hola Amigo como estas",
                    usuario ="Bien y tu mano"

                },
                new ModelChats
                {
                    Nombre = "Pedro",
                    UltimoMensaje = "mañana",
                    Hora = "Ayer",
                    Imagen = "manwhite.png",
                    remitente = "Hola Amigo como estas",
                    usuario ="Bien y tu mano"

                },
                new ModelChats
                {
                    Nombre = "Esteban",
                    UltimoMensaje = ":)",
                    Hora = "Ayer",
                    Imagen = "manwhite.png",
                    remitente = "Hola Amigo como estas",
                    usuario ="Bien y tu mano"

                },
                new ModelChats
                {
                    Nombre = "Ricardo Arjona",
                    UltimoMensaje = "....",
                    Hora = "Ayer",
                    Imagen = "manwhite.png",
                    remitente = "Hola Amigo como estas",
                    usuario ="Bien y tu mano"

                },
                new ModelChats
                {
                    Nombre = "Johan",
                    UltimoMensaje = "Siiu",
                    Hora = "Ayer",
                    Imagen = "manwhite.png",
                    remitente = "Hola Amigo como estas",
                    usuario ="Bien y tu mano"

                }
            };

            // Establece la colección como fuente de datos para el CollectionView
            ch.ItemsSource = ModelChat;

        }

        // Método que maneja la selección del chat
        private async void ch_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ch.SelectedItem != null)
            {
                ch.SelectedItem = null;
                // Verifica si se seleccionó un chat
                if (e.CurrentSelection.FirstOrDefault() is ModelChats selectedChat)
                {
                    // Navega a ChatPage pasando el chat seleccionado
                    await Navigation.PushAsync(new ChatPage(selectedChat));
                }

            // Limpia la selección después de navegar
            ((CollectionView)sender).SelectedItem = null;
            }
        }
    }
}
