using HastaTakip.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaTakip.DAL.Abstract
{
    public interface IAdres
    {
        void Ekle(string ulke, string il, string ilce, string kucukadres);
        void Sil(Adres a);
        List<Adres> GetAll();

    }
}
