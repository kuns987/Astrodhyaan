using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Astrodhyaan.Models
{

    [DataContract(IsReference = true)]
    public partial class AstrologerExpertEntity
    {
        
        [DataMember]
        public long Id { get; set; }
        [DataMember]
        public long AstroId { get; set; }
        [DataMember]
        public long ExpertId { get; set; }
        [DataMember]
        public List<ExpertMasterEntity> ExpertMasterList { get; set; }
    }
}
