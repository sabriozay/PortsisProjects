using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PortsisSip.Model;

namespace PortsisSip.View
{

	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Kayıt : ContentPage

	{
        string _dbpath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "PortsisMDb.db3");

        public Kayıt ()
		{
			InitializeComponent ();
		}

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var db = new SQLiteConnection(_dbpath);
            db.CreateTable<Müsteri>();
           // var maxpk = db.Table<Müsteri>().OrderByDescending(c => c.Id).FirstOrDefault();

            Müsteri frm = new Müsteri()
            {
                Id = 1,
                AdSoyad = AdSoyad.Text,
                Telefon = Telefon.Text,
                Adres=Adres.Text              

            };
            db.Insert(frm);
            await DisplayAlert(null, frm.AdSoyad + " Kaydedildi ", "Tamam");
            await Navigation.PushModalAsync(new View.AnaSayfa());


        }
    }
}