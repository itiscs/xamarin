using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SecondPage : ContentPage
	{
		public SecondPage ()
		{
			InitializeComponent ();

            TapGestureRecognizer tapGesture = new TapGestureRecognizer();

            tapGesture.Tapped += TapGesture_Tapped;

            lbl1.GestureRecognizers.Add(tapGesture);

            //imgPlus.Source = Device.OnPlatform(
            //    Android: ImageSource.FromResource("plus.png"),
            //    WinPhone: ImageSource.FromResource("plus.png"));


        }

        private void TapGesture_Tapped(object sender, EventArgs e)
        {
            BoxView box = new BoxView()
            {                
                WidthRequest = 100,
                HeightRequest = 100,
                Color = Color.Green
            };
            stk1.Children.Add(box);
        }
    }
}