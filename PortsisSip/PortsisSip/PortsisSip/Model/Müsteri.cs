using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace PortsisSip.Model
{
    class Müsteri
    {
        [PrimaryKey]
        public int Id { get; set; }
        public string AdSoyad { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }


    }
}
