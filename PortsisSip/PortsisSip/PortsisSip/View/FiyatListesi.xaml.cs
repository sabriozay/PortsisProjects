using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PortsisSip.Model;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PortsisSip.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FiyatListesi : ContentPage
	{
        List<Orders> flst = new List<Orders>();
		public FiyatListesi (){
           InitializeComponent ();
            flst.Add(new Orders("ÜRÜN", "  Fiyat", "Birim"));
            flst.Add(new Orders("MAKİNA HALISI", "	4,00 TL", "	M2"));
            flst.Add(new Orders("MAKİNA YÜN", "	4,00 TL", "	M2"));
            flst.Add(new Orders("SHAGGY", "	4,00 TL", "	M2"));
            flst.Add(new Orders("NEPAL HALI", "	4,00 TL", "	M2"));
            flst.Add(new Orders("STEP HALI	", "	4,00 TL", "	M2"));
            flst.Add(new Orders("HEREKE HALI", "	4,00 TL", "	M2"));
            myList.ItemsSource = flst;

		}
	}
}