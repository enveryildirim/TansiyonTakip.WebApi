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
    public class Kontrol
    {
        [DataMember]
        public int KontrolID{get;set;}
        [DataMember]
        public int DoktorID { get; set; }
        [DataMember]
        public int HastaID { get; set; }
        [DataMember]
        public KontrolTipi Turu { get; set; }
        [DataMember]
        public string Program { get; set; }
        [DataMember]
        public bool YeniMi { get; set; }
        [DataMember]
        public bool KontrolOlduMu { get; set; }
        [DataMember]
        public DateTime SonBakilmaTarihi { get; set; }
    }
    [DataContract]
    public enum KontrolTipi
    {
        [EnumMember]
        Tansiyon,
        [EnumMember]
        Seker
    }
}
