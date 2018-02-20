using HastaTakip.DAL.Abstract;
using HastaTakip.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaTakip.DAL.Concrete.EntityFramework
{
    public class EF_Doktor:IDoktor
    {
        EFContext db = new EFContext();
        public void Ekle(Doktor u)
        {
            db.Doktor.Add(u);
            db.SaveChanges();
        }

        public void Guncelle(Doktor u)
        {
            Doktor uye = db.Doktor.Where(p => p.DoktorID == u.DoktorID).FirstOrDefault();
            uye = u;
            db.SaveChanges();

        }

        public void Sil(Doktor u)
        {
            db.Doktor.Remove(u);
            db.SaveChanges();
        }

        public Doktor Get(int ID)
        {
            return db.Doktor.Where(p => p.DoktorID == ID).FirstOrDefault();
        }

        public List<Doktor> GetAll()
        {
            return db.Doktor.ToList();
        }

        public List<Doktor> ExecuteReturnList(string command, params object[] p)
        {
            return db.Doktor.SqlQuery(command, p).ToList();
        }

        public void Execute(string command, params object[] p)
        {
            db.Doktor.SqlQuery(command, p);
        }

        public int Login(string username, string password)
        {
            Doktor u = db.Doktor.Where(p => p.TC == username && p.Sifre == password).FirstOrDefault();
            if (u == null) return 0;
            else return u.DoktorID;
        }

       
    }
}
