using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Astrodhyaan.Models
{

    [DataContract(IsReference = true)]
    public partial class ExpertMasterEntity
    {
        
        [DataMember]
        public long Id { get; set; }
        [DataMember]
        public string ExpertName { get; set; }        
    }
}
