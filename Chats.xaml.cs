
using Microsoft.VisualBasic;
using System;

using System.Collections.ObjectModel;
using WhastApp.Model;


namespace WhastApp;

public partial class Chats : ContentPage
{
    public ObservableCollection<ModelChats> ModelChat { get; set; }
   
    public Chats()
	{
        InitializeComponent();

        ModelChat = new ObservableCollection<ModelChats>();
        ModelChat.Add(new ModelChats
        {
            Nombre = "Alex",
            UltimoMensaje = "ok",
            Hora = "12:09 a. m.",
            Imagen = "manwhite.png"
        });
        ModelChat.Add(new ModelChats
        {
            Nombre = "Camilo",
            UltimoMensaje = "Actividad2Movil.rar",
            Hora = "12:01 a. m.",
            Imagen = "manwhite.png"
        });

        ModelChat.Add(new ModelChats
        {
            Nombre = "Sebas",
            UltimoMensaje = "......",
            Hora = "Ayer",
            Imagen = "manwhite.png"
        });
        ModelChat.Add(new ModelChats
        {
            Nombre = "Luis",
            UltimoMensaje = ".......",
            Hora = "Ayer",
            Imagen = "manwhite.png"
        });

        ModelChat.Add(new ModelChats
        {
            Nombre = "Sofia",
            UltimoMensaje = "bueno",
            Hora = "Ayer",
            Imagen = "manwhite.png"
        });

        ModelChat.Add(new ModelChats
        {
            Nombre = "Pedro",
            UltimoMensaje = "mañana",
            Hora = "Ayer",
            Imagen = "manwhite.png"
        });

        ModelChat.Add(new ModelChats
        {
            Nombre = "Esteban",
            UltimoMensaje = ":)",
            Hora = "Ayer",
            Imagen = "manwhite.png"
        });

        ModelChat.Add(new ModelChats
        {
            Nombre = "Ricardo Arjona",
            UltimoMensaje = "....",
            Hora = "Ayer",
            Imagen = "manwhite.png"
        });

        ModelChat.Add(new ModelChats
        {
            Nombre = "Johan",
            UltimoMensaje = "Siiu",
            Hora = "Ayer",
            Imagen = "manwhite.png"
        });


        ch.ItemsSource = ModelChat;
    }
       

    private void ch_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if(ch.SelectedItem != null) {
            ch.SelectedItem = null;
        // Verificamos si se ha seleccionado un chat
        var selectedChat = (ModelChats)e.CurrentSelection.FirstOrDefault();

        if (selectedChat != null)
        {
            // Crear una nueva instancia de la página estática
            var chatPage = new ChatPage();

            // Navegar a la nueva página estática
            Navigation.PushAsync(chatPage);
        }
    }
    }

}
