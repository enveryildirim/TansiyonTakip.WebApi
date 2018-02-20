using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;
namespace HastaTakip.Entities
{
    [DataContract]
    public class Doktor
    {
        [DataMember]
        public int DoktorID{get;set;}
         [DataMember]
        public string Ad_Soyad { get; set; }
         [DataMember]
        public string TC { get; set; }
         [DataMember]
        public string Sifre { get; set; }
         [DataMember]
        public string Email { get; set; }
         [DataMember]
        public string GSM { get; set; }
         [DataMember]
        public virtual List<Kontrol> Kontroller { get; set; }
         public bool DoktorMu { get; set; }
      
    }
}
