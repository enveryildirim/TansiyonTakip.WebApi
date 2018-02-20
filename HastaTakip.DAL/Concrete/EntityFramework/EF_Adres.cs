using HastaTakip.DAL.Abstract;
using HastaTakip.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaTakip.DAL.Concrete.EntityFramework
{
    public class EF_Adres:IAdres
    {
        EFContext db = new EFContext();
        public void Ekle(string ulke, string il, string ilce, string kucukadres)
        {
            Adres a = new Adres() { Il = il, Ilce = ilce, KucukAdres = kucukadres, Ulke = ulke };
            db.Adresler.Add(a);
            db.SaveChanges();
        }

        public void Sil(Entities.Adres a)
        {
            db.Adresler.Remove(a);
            db.SaveChanges();
        }

        public List<Entities.Adres> GetAll()
        {
           return db.Adresler.ToList();
        }
    }
}
