using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HastaTakip.Entities
{
    public class KontrolDeger
    {
        public int ID { get; set; }
        public int KontrolID { get; set; }
        public string Deger { get; set; }
        public int KontrolSayisi { get; set; }
        public DateTime Tarih { get; set; }
        public bool DoktorKontrolEtti { get; set; }
        public virtual Kontrol Kontrol { get; set; }
    }
}
