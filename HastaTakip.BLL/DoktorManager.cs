using HastaTakip.DAL.Abstract;
using HastaTakip.Entities;
using Newtonsoft.Json;
using Ninject;
using Ninject.Extensions.Interception;
using Ninject.Extensions.Interception.Infrastructure.Language;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using HastaTakip.Util.Logging;
using Ninject.Modules;
namespace HastaTakip.BLL
{
    public class DoktorManager
    {
        private IDoktor _doktor=null;
        private IHasta _hasta=null;
        private IKontrol _kontrol = null;
        private IMesaj _mesaj = null;
        
        public DoktorManager()
        {
            IKernel kernel = new StandardKernel();
            //kernel.Intercept(p => true).With(new Log());
            kernel.Load(new InterceptorAllModule());
           
            _doktor = kernel.Get<IDoktor>();
            _hasta = kernel.Get<IHasta>();
            _kontrol = kernel.Get<IKontrol>();
            _mesaj = kernel.Get<IMesaj>();
            
        }
        /*Doktor İşlemleri*/
        public static string ListToJson(List<Doktor> d)
        {
            string a = JsonConvert.SerializeObject(d);
            a = "{\"Doktor\":" + a + "}";
            return a;
        }
        public static string ObjectToJson(Doktor d)
        {
            string a = JsonConvert.SerializeObject(d);
            //a = "{\"Doktor\":" + a + "}";
            return a;
        }
        public void DoktorEkle(Doktor u)
        {
            _doktor.Ekle(u);
        }
        public void DoktorGuncelle(Doktor u)
        {
          Doktor a= _doktor.Get(u.DoktorID);
          a.Ad_Soyad = u.Ad_Soyad;
          a.Sifre = u.Sifre;
            _doktor.Guncelle(a);
           
        }
        public void DoktorSil(Doktor u)
        {
            _doktor.Sil(u);
          
        }
        public int Login(string username, string sifre)
        {
            int durum=_doktor.Login(username, sifre);
            
            return durum;
        }
        public List<Doktor> GetAll() { return _doktor.GetAll(); }
        /*Hasta İşlemleri*/
        public List<Hasta> GetHastaByDoktorID(int id)
        {
            return _hasta.GetAll().Where(p => p.DoktorID == id).ToList();
             
        }
        public void HastaEkle(Hasta u)
        {
            _hasta.Ekle(u);
           
        }
        public void HastaSil(Hasta u)
        {
           _hasta.Sil(_hasta.Get(u.HastaID));
           
        }
        /*Kontrol İşlemleri*/
        public void KontrolEkle(Kontrol k)
        {
            _kontrol.Ekle(k);
        }
        public void KontrolGuncelle(Kontrol k)
        {
            _kontrol.Guncelle(k);
        }
        public void KontrolSil(Kontrol k)
        {
            _kontrol.Sil(k);
        }
        public List<Kontrol> GetKontroller(int id)
        {
            return _kontrol.GetByDoktor(id);
        }
        public List<Kontrol> GetKontrollerByHasta(int id)
        {
            return _kontrol.GetByHasta(id);
        }
        public Kontrol GetKontrol(int id)
        {
            return _kontrol.Get(id);
        }
        public string GetKontrolDegerByKontrolID(int id)
        {
            return _kontrol.GetProgram(id);
        }
        /*Mesaj İşlemleri*/
        public void MesajAt(string mesaj, int alici, int gonderen)
        {
            Mesaj m = new Mesaj() {Icerik=mesaj,AliciID=alici,GonderenID=gonderen };
            _mesaj.Ekle(m);
        }
        public Mesaj MesajOku(int id)
        {
            return _mesaj.Oku(id);
        }
        public List<Mesaj> GetByAlıcı(int id)
        {
            return _mesaj.GetByAlici(id);
        }
        public List<Mesaj> GetByGonderen(int id)
        {
            return _mesaj.GetByGonderen(id);
        }

    }
}
