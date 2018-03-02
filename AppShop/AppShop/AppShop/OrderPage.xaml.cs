using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppShop
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class OrderPage : ContentPage
	{
		public OrderPage ()
		{
			InitializeComponent ();
            Order ord = (Order)App.Current.Resources["Order"];
            lstOrders.ItemsSource = ord.Orders;
            
            
		}

        private void Button_Clicked(object sender, EventArgs e)
        {   
            Navigation.PopToRootAsync();
        }
    }
}