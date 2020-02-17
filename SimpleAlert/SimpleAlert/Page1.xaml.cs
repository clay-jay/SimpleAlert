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
	public partial class Page1 : ContentPage
	{
		public Page1 ()
		{
			InitializeComponent ();
		}

        private void StartBtn_Clicked(object sender, EventArgs e)
        {
            popupView.IsVisible = true;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            popupView.IsVisible = false;
        }
    }
}