using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;


namespace Astrodhyaan.Models
{

    [DataContract(IsReference = true)]
    public partial class UserConsultationChargesTransactionEntity
    {
        
        [DataMember]
        public long Id { get; set; }
        [DataMember]
        public long UserId { get; set; }
        [DataMember]
        public long AstroId { get; set; }
        [DataMember]
        public string ConsultId { get; set; }
        [DataMember]
        public string ConsultType { get; set; }
        [DataMember]
        public string CallingDetails { get; set; }
        [DataMember]
        public string ChannelNo { get; set; }
        [DataMember]
        public string CalledNo { get; set; }
        [DataMember]
        public string CallingNo { get; set; }
        [DataMember]
        public DateTime? StartDate { get; set; }
        [DataMember]
        public DateTime? EndDate { get; set; }
        [DataMember]
        public DateTime? Duration { get; set; }
        [DataMember]
        public string mou { get; set; }
        [DataMember]
        public DateTime? EndDate_Actual { get; set; }
        [DataMember]
        public DateTime? Duration_Actual { get; set; }
        [DataMember]
        public string mou_Actual { get; set; }
        [DataMember]
        public string Operator { get; set; }
        [DataMember]
        public string Circle { get; set; }
        [DataMember]
        public string ServerId { get; set; }
        [DataMember]
        public decimal? ConsultAmount { get; set; }
        [DataMember]
        public decimal? ConsultAstroCharge { get; set; }
        [DataMember]
        public long ConsultReviewId { get; set; }        
    }
}
