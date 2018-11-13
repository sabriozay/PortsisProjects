using Newtonsoft.Json;
using PortsisSip.Model;
using System;
using System.Collections.Generic;
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

        public async Task<getMaintOrderListRoot> GetMaintOrderListRoot(müsteripost mst)
        {
            var input = "http://onlinesiparis.portsispos.com/pos.asmx/SipAl?Adsoyad="+mst.AdSoyad+"&Telefon="+mst.Telefon+"&Adres="+mst.Adres+"&kod="+mst.Kod+"";
           var client = await GetClient();
            var result = await client.GetStringAsync(input);
            return JsonConvert.DeserializeObject<getMaintOrderListRoot>((result));
        }


    }
}
