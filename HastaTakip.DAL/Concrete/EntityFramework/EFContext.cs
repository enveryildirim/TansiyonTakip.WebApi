using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HastaTakip.Entities;
namespace HastaTakip.DAL.Concrete.EntityFramework
{
    public class EFContext:DbContext
    {
        public DbSet<Doktor> Doktor { get; set; }
        public DbSet<Hasta> Hasta { get; set; }
        public DbSet<Kontrol> Kontrol { get; set; }
        public DbSet<Mesaj> Mesajlar { get; set; }
    }
}
