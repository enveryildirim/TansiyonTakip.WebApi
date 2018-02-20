using HastaTakip.DAL.Abstract;
using HastaTakip.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaTakip.DAL.Concrete.EntityFramework
{
    public  class EF_KontrolDeger:IKontrolDeger
    {
        EFContext db = new EFContext();
        public void Ekle(KontrolDeger k)
        {
            db.KontrolDegerleri.Add(k);
        }

        public void Guncelle(KontrolDeger k)
        {
            KontrolDeger r = db.KontrolDegerleri.Where(p => p.ID == k.ID).FirstOrDefault();
            r = k;
            db.SaveChanges();
         }

        public void Sil(KontrolDeger k)
        {
            db.KontrolDegerleri.Remove(k);
            db.SaveChanges();
        }

        public List<KontrolDeger> Get(int id)
        {
            return db.KontrolDegerleri.Where(p=>p.ID==id).ToList();
        }

        public List<KontrolDeger> GetByKontrol(int id)
        {
            return db.KontrolDegerleri.Where(p => p.KontrolID == id).ToList();
        }
    }
}
