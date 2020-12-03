using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;


namespace Astrodhyaan.Models
{
    [DataContract(IsReference = true)]
    public partial class AdminPageCategorySubCategoryContentEntity
    {        
        [DataMember]
        public long Id { get; set; }
        [DataMember]
        public long PageId { get; set; }
        [DataMember]
        public long CategoryId { get; set; }
        [DataMember]
        public long SubCategoryId { get; set; }        
        [DataMember]
        public long ControlTypeId { get; set; }
        [DataMember]
        public long LanguageId { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public string CategoryContent { get; set; }
        [DataMember]
        public string CategoryUrl { get; set; }
        [DataMember]
        public long SeqNo { get; set; }
    }
}