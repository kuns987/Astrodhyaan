using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;


namespace Astrodhyaan.Models
{
    [DataContract(IsReference = true)]
    public partial class AdminSubCategoryEntity
    {       
        [DataMember]
        public long Id { get; set; }
        [DataMember]
        public long LanguageId { get; set; }
        [DataMember]
        public long PageId { get; set; }
        [DataMember]
        public long CategoryId { get; set; }
        [DataMember]
        public string SubCategoryName { get; set; }
        [DataMember]
        public long ControlTypeId { get; set; }
        [DataMember]
        public string SubCategoryHashId { get; set; }
        [DataMember]
        public List<AdminPageCategorySubCategoryContentEntity> AdminPageCategorySubCategoryContent { get; set; }
    }
}