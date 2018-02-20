using HastaTakip.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HastaTakip.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWS_Doktor" in both code and config file together.
    [ServiceContract]
    public interface IWS_Doktor
    {
        [OperationContract]
        int Login(string tc,string sifre);
        
        [OperationContract]
        void DoktorEkle(string tc, string sifre, string adsoyad);
        [OperationContract]
        void Guncelle(int id,string ad,string sifre);
        /*Hasta İşlemleri*/
        [OperationContract]
        string GetHastalarByDoktorID(int id);

        [OperationContract]
        void HastaEkle(string tc, int id);

        [OperationContract]
        string GetById(int id);

        [OperationContract]
        void HastaSil(int id, int hid);

        [OperationContract]
        void KontrolEkle(int id, int hid, int turu);

    }
}
