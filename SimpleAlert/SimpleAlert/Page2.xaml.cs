using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SimpleAlert
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page2 : ContentPage
	{
		public Page2 ()
		{
			InitializeComponent ();
		}

        private void BtnAlert_Clicked(object sender, EventArgs e)
        {
            alertBox.IsVisible = true;
        }

        private void BtnBack_Clicked(object sender, EventArgs e)
        {
            alertBox.IsVisible = false;
        }

        private void SystemAlert_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Alert", "Something is happening", "Ok");
        }
    }
}