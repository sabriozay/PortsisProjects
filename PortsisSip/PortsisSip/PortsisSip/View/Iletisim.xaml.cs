using Plugin.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PortsisSip.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Iletisim : ContentPage
	{
		public Iletisim ()
		{
			InitializeComponent ();
      
           
        }

        private void Ara_Clicked(object sender, EventArgs e)
        {
            var phoneDialer = CrossMessaging.Current.PhoneDialer;
            if (phoneDialer.CanMakePhoneCall)
                phoneDialer.MakePhoneCall("+905428080043");

        }
    }
}