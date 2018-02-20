using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaTakip.Entities
{
    public class Uye
    {
        public int ID { get; set; }
        public string TC { get; set; }
        public string AdSoyad { get; set; }
        public string Sifre { get; set; }
        public string Email { get; set; }
        public string Meslek { get; set; }
        public UyeTipi Tipi { get; set; }
        public bool Durum { get; set; }
        public bool Login { get; set; }
        public int AdresID { get; set; }
        public virtual Adres Adres { get; set; }
        public virtual List<Kontrol> Kontroller { get; set; }
        public virtual List<Mesaj> Mesajlar { get; set;}
    }

    public enum UyeTipi
    {
        Doktor,Hasta
    }
}
