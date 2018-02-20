using HastaTakip.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaTakip.DAL.Abstract
{
    public interface IMesaj
    {
        void Ekle(Mesaj m);
        Mesaj Oku(int id);
        List<Mesaj> GetByAlici(int aliciid);
        List<Mesaj> GetByGonderen(int aliciid);
    }
}
