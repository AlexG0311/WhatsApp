using Microsoft.VisualBasic;
using System.Collections.ObjectModel;
using WhastApp.Model;

namespace WhastApp;

public partial class ChatPage : ContentPage
{

    public ObservableCollection<Mensaje> Mensajes { get; set; }
    public ChatPage()
	{
		InitializeComponent();

        Mensajes = new ObservableCollection<Mensaje>();


        Mensajes.Add(new Mensaje

        {
            
            remitente = "Hoola maniiii",
            usuario = "Como estasssssss",



        });

        Mensajes.Add(new Mensaje
        {
            remitente = "Hoola maniiii",
            usuario = "Como estasssssss",


        });

        Mensajes.Add(new Mensaje
        {
            remitente = "Hoola maniiii",
            usuario = "Como estasssssss",


        });


        Mensajes.Add(new Mensaje
        {
            remitente = "Hoola maniiii",
            usuario = "Como estasssssss",


        });

        mensajes.ItemsSource = Mensajes;
    }


}