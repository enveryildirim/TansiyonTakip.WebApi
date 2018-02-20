using HastaTakip.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaTakip.DAL.Abstract
{
    public interface IDoktor
    {
        void Ekle(Doktor u);
        void Guncelle(Doktor u);
        void Sil(Doktor u);
        Doktor Get(int ID);
        List<Doktor> GetAll();
        List<Doktor> ExecuteReturnList(string command, params object[] p);
        void Execute(string command, params object[] p);
        int Login(string username, string password);
    }
}
