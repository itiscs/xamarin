using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamApp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

		}

        private void btn1_Clicked(object sender, EventArgs e)
        {
            lbl1.Text = $"Привет, {txtName.Text}!";
            
        }

        private void btnNext_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SecondPage());

        }

        private void btnThird_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GridPage());


        }
    }
}
