using HastaTakip.DAL.Abstract;
using HastaTakip.Entities;
using HastaTakip.Util.Logging;
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

namespace HastaTakip.BLL
{
    public class HastaManager
    {
        private IDoktor _doktor = null;
        private IHasta _hasta = null;
        private IKontrol _kontrol = null;
        private IMesaj _mesaj = null;
        
           public HastaManager()
            {
                IKernel kernel = new StandardKernel();
                //kernel.Intercept(p => true).With(new Log());
                kernel.Load(new InterceptorAllModule());
                _doktor = kernel.Get<IDoktor>();
                _hasta = kernel.Get<IHasta>();
                _kontrol = kernel.Get<IKontrol>();
                _mesaj = kernel.Get<IMesaj>();
            }

        /*Hasta İşlmleri*/
           public static string ListToJson(List<Hasta> d)
           {
               string a = JsonConvert.SerializeObject(d);
               a = "{\"Hasta\":" + a + "}";
               return a;
           }
           public static string ObjectToJson(Hasta d)
           {
               string a = JsonConvert.SerializeObject(d);
               a = "{\"Hasta\":" + a + "}";
               return a;
           }
           public static string ObjectToJson(Kontrol d)
           {
               string a = JsonConvert.SerializeObject(d);
               //a = "{\"Kontrol\":" + a + "}";
               return a;
           }
           public static string ListToJson(List<Kontrol> k)
           {
               string a = JsonConvert.SerializeObject(k);
               a = "{\"Kontrol\":" + a + "}";
               return a;
           }
           public void HastaGuncelle(Hasta u)
           {
                _hasta.Guncelle(u);
           }
           public int Login(string  username,string sifre)
           {
               return _hasta.Login(username,sifre);
           }
        /*Kontrol İşlemleri*/
           public List<Kontrol> GetKontrollerByHastaID(int id)
           {
               return _kontrol.GetByHasta(id);
           }
           public Kontrol GetKontrol(int id)
           {
               return _kontrol.Get(id);

           }
        /*Kontrol Deger İşlemleri*/
           public void KontrolDegerEkle(int id,string kd)
           {
               _kontrol.DegerEkle(id, kd);
           }
           public void KontrolDegerGuncelle(int id,string kd)
           {
               _kontrol.DegerGuncelle(id,kd);
           }
           public void KontrolDegerSil(int id,string kd)
           {
               _kontrol.DegerGuncelle(id,kd);
           }
           public string GetKontrolDeger(int id)
           {
              return _kontrol.GetProgram(id);
           }
        /*Mesaj İşlemleri*/
           public void MesajAt(string mesaj, int alici, int gonderen)
           {
               Mesaj m = new Mesaj() { Icerik = mesaj, AliciID = alici, GonderenID = gonderen };
               _mesaj.Ekle(m);
           }
           public Mesaj MesajOku(int id)
           {
               return _mesaj.Oku(id);
           }
           public List<Mesaj> GetByAlici(int id)
           {
               return _mesaj.GetByAlici(id);
           }
           public List<Mesaj> GetByGonderen(int id)
           {
               return _mesaj.GetByGonderen(id);
           }

    }
}
