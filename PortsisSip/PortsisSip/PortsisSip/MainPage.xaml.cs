using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using PortsisSip.Model;
using System.IO;

namespace PortsisSip
{
    public partial class MainPage : ContentPage
    {
        string _dbpath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "PortsisMDb.db3");

        public MainPage()
        {

            InitializeComponent();
            var db = new SQLiteConnection(_dbpath);
            db.CreateTable<Müsteri>();
            var veriler = db.Table<Müsteri>().FirstOrDefault(x=> x.Id==1);


            if (veriler != null)
            {
                Navigation.PushModalAsync(new View.AnaSayfa());
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
             Navigation.PushModalAsync(new View.Kayıt());
        }
    }
}
