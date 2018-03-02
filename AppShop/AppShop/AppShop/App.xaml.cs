using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace AppShop
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

			MainPage = new NavigationPage( new AppShop.MainPage());
		}

		protected override void OnStart ()
		{
            // Handle when your app starts
            App.Current.Resources = new ResourceDictionary();
            App.Current.Resources.Add("Order", new Order());
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
