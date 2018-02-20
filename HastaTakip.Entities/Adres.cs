using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HastaTakip.Entities
{
   public class Adres
    {
        public int ID { get; set; }
        public string Ulke { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }
        public string KucukAdres { get; set; }
    }
}
