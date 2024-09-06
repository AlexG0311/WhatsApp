using Microsoft.VisualBasic;
using System.Collections.ObjectModel;
using WhastApp.Model;

namespace WhastApp;

public partial class ChatPage : ContentPage
{

    public ModelChats Model { get; set; }
    public ChatPage(ModelChats model)
	{
		InitializeComponent();

        this.Model = model;

        this.BindingContext = this;
    }


}