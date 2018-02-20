using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using HastaTakip.Entities;
namespace HastaTakip.WCF
{
    [DataContract]
    public class A
    {
        public List<Hasta> H { get; set; }
    }
}