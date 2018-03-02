using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppShop
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            List<Phone> lst = new List<Phone>();
            lst.Add(new Phone()
            {
                ID = 1,
                Brand = "IPhone",
                Model = "X",
                Price = 90000,
                 ImageFile = "iphone.png"
            });
            lst.Add(new Phone()
            {
                ID = 2,
                Brand = "Samsung",
                Model = "Galaxy S8",
                Price = 50000,
                ImageFile = "samsung.png"
            });
            lst.Add(new Phone()
            {
                ID = 3,
                Brand = "Xaomi",
                Model = "Mi Mix",
                Price = 35000,
                ImageFile = "xaomi.png"
            });
            lstPhones.ItemsSource = lst;
        }

        private void lstPhones_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Navigation.PushAsync(new PhonePage((Phone)e.Item));

        }
    }
}
