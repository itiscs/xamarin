using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppGame
{
	public partial class MainPage : ContentPage
	{
        PlayerService serv = new PlayerService();

		public MainPage()
		{
			InitializeComponent();

		}

        protected override async void OnAppearing()
        {
            PlayersList.ItemsSource = await serv.GetPlayers(); 
        }
    }
}
