using HastaTakip.DAL.Abstract;
using HastaTakip.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaTakip.DAL.Concrete.EntityFramework
{
    public class EF_Kontrol:IKontrol
    {
        EFContext db = new EFContext();
        public void Ekle(Kontrol k)
        {
            List<Kontrol> ka = db.Kontrol.ToList();

            db.Kontrol.Add(k);
            db.SaveChanges();
        }

        public void Guncelle(Kontrol k)
        {
            Kontrol r = db.Kontrol.Where(p => p.KontrolID == k.KontrolID).FirstOrDefault();
            r = k;
            db.SaveChanges();
        }

        public void Sil(Kontrol k)
        {
            db.Kontrol.Remove(k);
            db.SaveChanges();
        }

        public Kontrol Get(int id)
        {
            return db.Kontrol.Where(p => p.KontrolID == id).FirstOrDefault();
        }

        public List<Kontrol> GetByHasta(int hastaid)
        {
            return db.Kontrol.Where(p => p.HastaID == hastaid).ToList();
        }

        public List<Kontrol> GetByDoktor(int doktorid)
        {
            return db.Kontrol.Where(p => p.DoktorID == doktorid).ToList();
        }

        public List<Kontrol> GetAll()
        {
            return db.Kontrol.ToList();
        }

        public void KontrolEt(int id)
        {
            Kontrol k = db.Kontrol.Where(p => p.KontrolID == id).FirstOrDefault();
            
        }
        public void DegerEkle(int id,string program) 
        {
            Kontrol k = db.Kontrol.Where(p=>p.KontrolID==id).FirstOrDefault();
            if (k.Program.Length > 0)
                k.Program += "," + program;
            else k.Program = program;
            db.SaveChanges();
        }
        public void DegerGuncelle(int id, string program)
        {
            Kontrol k = db.Kontrol.Where(p => p.KontrolID == id).FirstOrDefault();
            k.Program = program;
            db.SaveChanges();
        }
        
        public string GetProgram(int id)
        {
            return db.Kontrol.Where(p => p.KontrolID == id).FirstOrDefault().Program;
        }
    }
}
