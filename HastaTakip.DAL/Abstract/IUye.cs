
using HastaTakip.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaTakip.DAL.Abstract
{
    public interface IUye
    {
         void Ekle(Uye u);
         void Guncelle(Uye u);
         void Sil(Uye u);
         Uye Get(int ID);
         List<Uye> GetAll();
         List<Uye> ExecuteReturnList(string command,params object[] p);
         void Execute(string command,params object[] p);
         bool Login(string username, string password);
       
   
    }
}
