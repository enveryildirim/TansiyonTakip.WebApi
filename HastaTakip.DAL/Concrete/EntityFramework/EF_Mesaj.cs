using HastaTakip.DAL.Abstract;
using HastaTakip.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaTakip.DAL.Concrete.EntityFramework
{
    public class EF_Mesaj:IMesaj
    {
        EFContext db = new EFContext();
        public void Ekle(Mesaj m)
        {
            db.Mesajlar.Add(m);
            db.SaveChanges();
        }

        public Mesaj Oku(int id)
        {
            return db.Mesajlar.Where(p => p.MesajID == id).FirstOrDefault();
        }

        public List<Mesaj> GetByAlici(int aliciid)
        {
            return db.Mesajlar.Where(p => p.AliciID == aliciid).ToList();
        }

        public List<Mesaj> GetByGonderen(int gonderenid)
        {
            return db.Mesajlar.Where(p => p.GonderenID == gonderenid).ToList();
        }
    }
}
