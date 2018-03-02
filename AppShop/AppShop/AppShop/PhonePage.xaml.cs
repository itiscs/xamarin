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
	public partial class PhonePage : ContentPage
	{
        Phone phone;
		public PhonePage (Phone p)
		{
            InitializeComponent ();
            phone = p;
            BindingContext = p;
            NavigationPage.SetHasNavigationBar(this, false);
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            Order ord = (Order) App.Current.Resources["Order"];
            OrderItem oi = ord.Orders.FirstOrDefault(o => o.Phone.ID == phone.ID);
            if (oi == null)
                ord.Orders.Add(new OrderItem() { Phone = phone, Count = 1 });
            else
                oi.Count++;
            App.Current.Resources["Order"] = ord;

            Navigation.PushAsync(new OrderPage());
        }
    }
}