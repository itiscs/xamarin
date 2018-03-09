using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Models;
using Xamarin.Forms;

namespace TodoApp
{
	public partial class MainPage : ContentPage
	{
        public MainPage()
		{
            InitializeComponent();

            lblPath.Text = App.Database.ToString();

		}

        protected override void OnAppearing()
        {
            todosList.ItemsSource = App.Database.GetItems();
            base.OnAppearing();
        }



        private void todosList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Navigation.PushAsync(new TodoPage((Todo)e.SelectedItem));

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TodoPage(new Todo()));

        }
    }
}
