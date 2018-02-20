using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace HastaTakip.Entities
{
   [DataContract]
   public class Mesaj
    {
        [DataMember]
        public int MesajID { get; set; }
        [DataMember]
        public int GonderenID { get; set; }
        [DataMember]
        public int AliciID { get; set; }
        [DataMember]
        public string Icerik { get; set; }
        [DataMember]
        public DateTime Tarih { get; set; }
        [DataMember]
        public bool Durum { get; set; }
        
    }
}
