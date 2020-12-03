using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;


namespace Astrodhyaan.Models
{

    [DataContract(IsReference = true)]
    public partial class AstrologerReviewEntity
    {
        
        [DataMember]
        public long Id { get; set; }
        [DataMember]
        public long AstroId { get; set; }
        [DataMember]
        public long UserId { get; set; }
        [DataMember]
        public long ParentReviewId { get; set; }
        [DataMember]
        public string Review { get; set; }
        [DataMember]
        public DateTime? ReviewDate { get; set; }
        [DataMember]
        public decimal? Rating { get; set; }
        [DataMember]
        public bool? IsViewed { get; set; }
        [DataMember]
        public bool? IsLiked { get; set; }
        [DataMember]
        public long LikeCount { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public List<AstrologerReviewEntity> AstrologerReviewList { get; set; }
    }
}
