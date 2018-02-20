using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HastaTakip.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWS_Hasta" in both code and config file together.
    [ServiceContract]
    public interface IWS_Hasta
    {
        [OperationContract]
        string GetKontrollerByHastaID(int id);
        [OperationContract]
        string GetKontrolByID(int id);
        [OperationContract]
        int Login(string tc, string sifre);
        [OperationContract]
        void DegerEkle(int id,string deger);
        [OperationContract]
        void DegerSil(int id,string program);
        [OperationContract]
        void DegerGuncelle(int id,string program);
    }
}
