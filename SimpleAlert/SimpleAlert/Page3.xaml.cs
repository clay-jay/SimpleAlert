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
	public partial class Page3 : ContentPage
	{
		public Page3 ()
		{
			InitializeComponent ();
            //To navigate through pages first need to set up the route 
            Routing.RegisterRoute("Page4", typeof(Page4));
		}

        async private void Button_Clicked(object sender, EventArgs e)
        {
            //then just use async method to navigate
            await Shell.Current.GoToAsync("Page4");
        }
    }
}