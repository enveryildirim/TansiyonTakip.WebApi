using HastaTakip.DAL.Abstract;
using HastaTakip.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaTakip.DAL.Concrete.EntityFramework
{
    public class EF_Hasta:IHasta
    {
        EFContext db = new EFContext();
        public void Ekle(Hasta u)
        {
            db.Hasta.Add(u);
            db.SaveChanges();
        }

        public void Guncelle(Hasta u)
        {
            Hasta uye = db.Hasta.Where(p => p.HastaID == u.HastaID).FirstOrDefault();
            uye = u;
            db.SaveChanges();

        }

        public void Sil(Hasta u)
        {
            db.Hasta.Remove(u);
            db.SaveChanges();
        }

        public Hasta Get(int ID)
        {
            return db.Hasta.Where(p => p.HastaID == ID).FirstOrDefault();
        }

        public List<Hasta> GetAll()
        {
            return db.Hasta.ToList();
        }

        public List<Hasta> ExecuteReturnList(string command,params object[] p)
        {
            return db.Hasta.SqlQuery(command, p).ToList(); 
        }

        public void Execute(string command,params object[] p)
        {
            db.Hasta.SqlQuery(command, p);
        }

        public int Login(string username, string password)
        {
            Hasta u = db.Hasta.Where(p => p.TC == username && p.Sifre == password).FirstOrDefault();
            if (u == null) return 0;
            else  return u.HastaID;
        }
    }
}
