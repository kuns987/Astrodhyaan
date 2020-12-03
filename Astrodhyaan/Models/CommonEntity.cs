using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;


namespace Astrodhyaan.Models
{
    [DataContract(IsReference = true)]
    public partial class CommonEntity
    {
        
        [DataMember]
        public long cId { get; set; }
        [DataMember]
        public string DDType { get; set; }
        [DataMember]
        public long DDValue { get; set; }
        [DataMember]
        public string DDText { get; set; }
    }
}