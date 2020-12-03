using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;


namespace Astrodhyaan.Models
{
    [DataContract(IsReference = true)]
    public partial class AdminPageEntity
    {
        [DataMember]
        public long Id { get; set; }
        [DataMember]
        public long LanguageId { get; set; }
        [DataMember]
        public string PageName { get; set; }
        [DataMember]
        public string PageUrl { get; set; }
        [DataMember]
        public string BannerUrl { get; set; }        
        [DataMember]
        public List<AdminCategoryEntity> AdminCategory { get; set; }
    }
}