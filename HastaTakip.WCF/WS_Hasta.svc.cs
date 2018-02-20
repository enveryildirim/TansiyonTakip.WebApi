using HastaTakip.BLL;
using HastaTakip.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HastaTakip.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WS_Hasta" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select WS_Hasta.svc or WS_Hasta.svc.cs at the Solution Explorer and start debugging.
    public class WS_Hasta : IWS_Hasta
    {
        DoktorManager dm = new DoktorManager();
        HastaManager hm = new HastaManager();
        public string GetKontrollerByHastaID(int id)
        {
           List<Kontrol> list=  hm.GetKontrollerByHastaID(id);
           string a= HastaManager.ListToJson(list);
           return a;
        }



        public int Login(string tc, string sifre)
        {

            return hm.Login(tc,sifre);
        }


        public string GetKontrolByID(int id)
        {
            Kontrol k = hm.GetKontrol(id);
            return HastaManager.ObjectToJson(k);
        }


        public void DegerEkle(int id, string deger)
        {
            hm.KontrolDegerEkle(id,deger);
        }

        public void DegerSil(int id, string program)
        {
            hm.KontrolDegerSil(id,program);
        }

        public void DegerGuncelle(int id, string program)
        {
            hm.KontrolDegerGuncelle(id, program);
        }
    }
}
