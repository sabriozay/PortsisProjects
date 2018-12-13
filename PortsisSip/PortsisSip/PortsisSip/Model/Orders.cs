using System;
using System.Collections.Generic;
using System.Text;

namespace PortsisSip.Model
{
   public class Orders
    {
        public static int mode;
        public String Order { get; set; }
        public string Fiyat { get; set; }
        public String Birim { get; set; }
        public Orders(String morder,string mfiyat,String mbirim)
        {
            this.Order = morder;
            this.Fiyat = mfiyat;
            this.Birim = mbirim;
        }
    }
}
