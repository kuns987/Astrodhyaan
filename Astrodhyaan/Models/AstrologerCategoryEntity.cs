using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
namespace Astrodhyaan.Models
{

    [DataContract(IsReference = true)]
    public partial class AstrologerCategoryEntity
    {
        
        [DataMember]
        public long Id { get; set; }
        [DataMember]
        public long AstroId { get; set; }
        [DataMember]
        public long CategoryId { get; set; }
        [DataMember]
        public List<CategoryMasterEntity> CategoryMasterList { get; set; }
    }
}
