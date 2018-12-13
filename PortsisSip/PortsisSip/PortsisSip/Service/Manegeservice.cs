using Newtonsoft.Json;
using PortsisSip.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PortsisSip.Service
{
   public class Manegeservice
    {

         public async Task<HttpClient> GetClient()
        {
          HttpClient client = new HttpClient();
           client.DefaultRequestHeaders.Add("Accept", "application/json");
            return client;
        }

        public async void GetMaintOrderListRoot(müsteripost mst)
        {
            mst.AdSoyad = degis(mst.AdSoyad);
            mst.Adres = degis(mst.Adres);
            var input = "http://onlinesiparis.portsispos.com/pos.asmx/SipAl?Adsoyad="+mst.AdSoyad+"&Telefon="+mst.Telefon+"&Adres="+mst.Adres+ "&Aciklama="+ "OnlineSip" +"&kod=" + mst.Kod+"";
       //     var input = "http://onlinesiparis.portsispos.com/pos.asmx/SipAl?Adsoyad=sabri&Telefon=234&Adres=asd&Aciklama=asdasd&kod=reyelhali";
            var client = await GetClient();
            var result = await client.GetStringAsync(input);
           
        }
        private string degis(string gelen)
        {
            return String.Join("", gelen.Normalize(NormalizationForm.FormD).Where(c => char.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark));
        }



    }
}
