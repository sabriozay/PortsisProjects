using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;
using SQLite;
using PortsisSip.Model;
using System.Net;
using System.Collections.Specialized;
using System.Net.Http;
using Newtonsoft.Json;
using PortsisSip.Service;
using Plugin.Share;

namespace PortsisSip.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AnaSayfa : ContentPage
    {
       
       
        string _dbpath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "PortsisMDb.db3");
        müsteripost mst = new müsteripost();
        HttpClient client = new HttpClient();
        Manegeservice mser = new Manegeservice();
        private Uri murl;
     
        public AnaSayfa ()
		{
            var db = new SQLiteConnection(_dbpath);
            db.CreateTable<Müsteri>();
            var veriler = db.Table<Müsteri>().FirstOrDefault(x => x.Id == 1);
            InitializeComponent();
            mst.AdSoyad = veriler.AdSoyad;
            mst.Adres = veriler.Adres;
            mst.Telefon = veriler.Telefon;
            mst.Kod = "reyelhali";
       
        }

   
        private async void SiparisVer_Clicked(object sender, EventArgs e)
        {
          var cevap=  await DisplayAlert("Siparis ver","Siparis vermek istiyormusunuz","evet","hayır");
            if (cevap)
            {             
                mser.GetMaintOrderListRoot(mst);                

            }
        }

        
        private async void Galeri_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new View.Galeri());
        }

        private async void İletisim_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new View.Iletisim());

        }

        private async void fiyatlist_Clicked(object sender, EventArgs e)
        {
          await  Navigation.PushModalAsync(new View.FiyatListesi());
        }

        private async void hakkımızda_Clicked(object sender, EventArgs e)
        {
          await  Navigation.PushModalAsync(new View.Hakkimizda());
        }

        private void Youtube_Clicked(object sender, EventArgs e)
        {
            CrossShare.Current.OpenBrowser("https://www.youtube.com/watch?v=8tpgyrR5RYI&feature=youtu.be");
        }
    }
}