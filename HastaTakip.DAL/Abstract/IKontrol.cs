using HastaTakip.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaTakip.DAL.Abstract
{
   public interface IKontrol
    {
       void Ekle(Kontrol k);
       void Guncelle(Kontrol k);
       void Sil(Kontrol k);
       Kontrol Get(int id);
       List<Kontrol> GetByHasta(int hastaid);
       List<Kontrol> GetByDoktor(int doktorid);
       List<Kontrol> GetAll();
       void KontrolEt(int id);
       string GetProgram(int id);
       void DegerEkle(int id, string program);
       void DegerGuncelle(int id, string program);
       
    }
}
