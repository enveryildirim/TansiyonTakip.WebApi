using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HastaTakip.Entities
{
    [DataContract]
    public class Hasta
    {

        [DataMember]
        public int HastaID {get;set;}
         [DataMember]
        public string Ad_Soyad {get;set;}
         [DataMember]
        public string TC {get;set;}
         [DataMember]
        public string Sifre { get; set; }
         [DataMember]
        public string Email { get; set; }
         [DataMember]
        public string GSM { get; set; }
         [DataMember]
        public int DoktorID { get; set; }
         [DataMember]
        public virtual List<Kontrol> Kontroller { get; set; }
       
    }
}
