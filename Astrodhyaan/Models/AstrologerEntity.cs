using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Globalization;

namespace Astrodhyaan.Models
{

    [DataContract(IsReference = true)]
    public partial class AstrologerEntity
    {
        public AstrologerEntity()
        {
            System.Globalization.RegionInfo objRegInfo = new RegionInfo("en-IN");
            string syb = objRegInfo.CurrencySymbol;
            rupee = syb;
        }
        [DataMember]
        public long Id { get; set; }
        [DataMember]
        public string AstroUniqueId { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string EmailId { get; set; }
        [DataMember]
        public string MobileNo { get; set; }
        [DataMember]
        public string AlternateNo { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public long PrimaryLanguageId { get; set; }
        [DataMember]
        public long SecondaryLanguageId { get; set; }
        [DataMember]
        public string Gender { get; set; }
        [DataMember]
        public decimal? Age { get; set; }
        [DataMember]
        public float? Experience { get; set; }
        [DataMember]
        public string City { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public string Country { get; set; }
        [DataMember]
        public string PanCardNo { get; set; }
        [DataMember]
        public string AadharCardNo { get; set; }
        [DataMember]
        public string BankName { get; set; }
        [DataMember]
        public string BankAccountType { get; set; }
        [DataMember]
        public string BankAccountName { get; set; }
        [DataMember]
        public string BankAccountNo { get; set; }
        [DataMember]
        public string BankIFSCCode { get; set; }
        [DataMember]
        public string BankBranchAddress { get; set; }
        [DataMember]
        public string GSTNo { get; set; }
        [DataMember]
        public bool? MobileVerified { get; set; }
        [DataMember]
        public bool? EmailVerified { get; set; }
        [DataMember]
        public decimal? ChatRate { get; set; }
        [DataMember]
        public bool? ChatOnlineStatus { get; set; }
        [DataMember]
        public DateTime? NextChatOnlineTime { get; set; }
        [DataMember]
        public decimal? CallRate { get; set; }
        [DataMember]
        public bool? CallOnlineStatus { get; set; }
        [DataMember]
        public DateTime? NextCallOnlineTime { get; set; }
        [DataMember]
        public bool? PromotionalStatus { get; set; }
        [DataMember]
        public decimal? PromotionalRate { get; set; }
        [DataMember]
        public float? DefaultRatingPoint { get; set; }
        [DataMember]
        public string ProfileSummary { get; set; }
        [DataMember]
        public string ProfilePicURL { get; set; }
        [DataMember]
        public bool? IsActive { get; set; }
        [DataMember]
        public bool? IsVerified { get; set; }
        [DataMember]
        public string AD_Badge_Status { get; set; }
        [DataMember]
        public long CreatedBy { get; set; }
        [DataMember]
        public DateTime? CreatedDate { get; set; }
        [DataMember]
        public long UpdatedBy { get; set; }
        [DataMember]
        public DateTime? UpdatedDate { get; set; }
        [DataMember]
        public string rupee { get; set; }
        [DataMember]
        public List<AstrologerReviewEntity> AstrologerReviewList { get; set; }
        [DataMember]
        public List<AstrologerCategoryEntity> AstrologerCategoryList { get; set; }
        [DataMember]
        public List<AstrologerExpertEntity> AstrologerExpertList { get; set; }
        [DataMember]
        public List<UserConsultationChargesTransactionEntity> UserConsultationChargesTransactionList { get; set; }
        [DataMember]
        public List<AstrologerNotificationEntity> AstrologerNotificationList { get; set; }
        [DataMember]
        public List<AstrologerPaymentTransactionEntity> AstrologerPaymentTransactionList { get; set; }
        [DataMember]
        public List<LanguageMasterEntity> LanguageMasterList { get; set; }
    }
}
