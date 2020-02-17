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
            btnBack.IsVisible = true;
            boxView.IsVisible = true;
            label.IsVisible = true;
            stackL.BackgroundColor = Color.FromHex("#C0808080");
        }

        private void BtnBack_Clicked(object sender, EventArgs e)
        {
            btnBack.IsVisible = false;
            boxView.IsVisible = false;
            label.IsVisible = false;
            stackL.BackgroundColor = Color.Transparent;
        }
    }
}