using HastaTakip.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaTakip.DAL.Abstract
{
   public interface IHasta
    {
       void Ekle(Hasta u);
       void Guncelle(Hasta u);
       void Sil(Hasta u);
       Hasta Get(int ID);
       List<Hasta> GetAll();
       List<Hasta> ExecuteReturnList(string command, params object[] p);
       void Execute(string command, params object[] p);
       int Login(string username, string password);
    }
}
