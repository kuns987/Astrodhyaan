using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Astrodhyaan.Models
{

    [DataContract(IsReference = true)]
    public partial class UserMasterEntity
    {
        
        [DataMember]
        public long Id { get; set; }
        [DataMember]
        public string UserUniqueId { get; set; }
        [DataMember]
        public string UserType { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string EmailId { get; set; }
        [DataMember]
        public string MobileNo { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public long PrimaryLanguageId { get; set; }
        [DataMember]
        public long SecondaryLanguageId { get; set; }
        [DataMember]
        public string Gender { get; set; }
        [DataMember]
        public DateTime? DateOfBirth { get; set; }
        [DataMember]
        public DateTime? TimeOfBirth { get; set; }
        [DataMember]
        public string BirthPlace { get; set; }
        [DataMember]
        public string ProfilePicURL { get; set; }
        [DataMember]
        public bool? MobileVerified { get; set; }
        [DataMember]
        public long CreatedBy { get; set; }
        [DataMember]
        public DateTime? CreatedDate { get; set; }
        [DataMember]
        public long UpdatedBy { get; set; }
        [DataMember]
        public DateTime? UpdatedDate { get; set; }
        [DataMember]
        public List<UserConsultationChargesTransactionEntity> UserConsultationChargesTransactionList { get; set; }
        [DataMember]
        public List<AstrologerEntity> Astrologers { get; set; }
        [DataMember]
        public List<UserNotificationEntity> UserNotificationList { get; set; }
        [DataMember]
        public List<UserDeviceEntity> UserDeviceList { get; set; }
        [DataMember]
        public List<UserPaymentTransactionEntity> UserPaymentTransactionList { get; set; }
        [DataMember]
        public List<LanguageMasterEntity> LanguageMasterList { get; set; }
    }
}
