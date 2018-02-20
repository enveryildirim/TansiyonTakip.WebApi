using HastaTakip.BLL;
using HastaTakip.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HastaTakip.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WS_Doktor" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select WS_Doktor.svc or WS_Doktor.svc.cs at the Solution Explorer and start debugging.
    public class WS_Doktor : IWS_Doktor
    {

        DoktorManager dm = new DoktorManager();
        HastaManager hm = new HastaManager();
        public int Login(string tc,string sifre)
        {
          return dm.Login(tc, sifre);
           
        }
        
        public void DoktorEkle(string tc,string sifre,string adsoyad)
        {
            Doktor d = new Doktor() {TC=tc,Sifre=sifre,Ad_Soyad=adsoyad};
            dm.DoktorEkle(d);
        }
        public void Guncelle(int id,string ad,string sifre)
        {
            dm.DoktorGuncelle(new Doktor() { DoktorID = id, Ad_Soyad = ad, Sifre = sifre });    
        }
        /*Hasta İşlemleri*/
        public void HastaEkle(string tc,int id)
        {
            dm.HastaEkle(new Hasta() {TC=tc,DoktorID=id});
        }
        public string GetHastalarByDoktorID(int id)
        {
            return HastaManager.ListToJson(dm.GetHastaByDoktorID(id));
             
        }
        public string GetById(int id)
        {
          Doktor d=  dm.GetAll().Where(p => p.DoktorID == id).FirstOrDefault();
          return DoktorManager.ObjectToJson(d);
        }
        public void HastaSil(int id, int hid)
        {
            dm.HastaSil(new Hasta() { HastaID = hid, DoktorID = id });
        }
        public void KontrolEkle(int id, int hid, int turu) 
        {
            dm.KontrolEkle(new Kontrol() {DoktorID=id,HastaID=hid,Turu=(KontrolTipi)turu,Program="",SonBakilmaTarihi=DateTime.Now,YeniMi=true,KontrolOlduMu=false });
        }
    }
}
