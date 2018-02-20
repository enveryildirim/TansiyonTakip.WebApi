using HastaTakip.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaTakip.DAL.Abstract
{
    public interface IKontrolDeger
    {
        void Ekle(KontrolDeger k);
        void Guncelle(KontrolDeger k);
        void Sil(KontrolDeger k);
        List<KontrolDeger> Get(int id);
        List<KontrolDeger> GetByKontrol(int id);
    }
}
