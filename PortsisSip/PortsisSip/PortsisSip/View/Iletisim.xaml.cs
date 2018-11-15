using Plugin.Messaging;
using Plugin.Share;
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

        private void Fb_Clicked(object sender, EventArgs e)
        {
            CrossShare.Current.OpenBrowser("https://www.facebook.com/reyelhaliyikama");
        }

        private void Ins_Clicked(object sender, EventArgs e)
        {
            CrossShare.Current.OpenBrowser("https://www.instagram.com/");
        }

        private void WebSitesi_Clicked(object sender, EventArgs e)
        {
            CrossShare.Current.OpenBrowser("http://www.reyelhaliyikama.com/");
        }

        private void AdresLink_Clicked(object sender, EventArgs e)
        {
            CrossShare.Current.OpenBrowser("https://www.google.com/maps/place/REYEL+HALI+YIKAMA/@41.0009291,29.1936606,17z/data=!3m1!4b1!4m5!3m4!1s0x14cad3c8b2616565:0x2cb5376631cbda73!8m2!3d41.0009251!4d29.1958493");
        }
    }
}