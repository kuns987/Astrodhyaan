using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Astrodhyaan.Models
{
    public class APIRequestObjects
    {
        
    }
    public class AdminPageRequest
    {
        [DataMember]
        public long PageId { get; set; }
        [DataMember]
        public long LanguageId { get; set; }
    }
    public class MobileHomeRequest
    {
        [DataMember]
        public long PageId { get; set; }
        [DataMember]
        public long LanguageId { get; set; }
        [DataMember]
        public long UserId { get; set; }
    }
    public class SaveMessageRequest
    {
        [DataMember]
        public long teamId { get; set; }
        [DataMember]
        public long coachId { get; set; }
        [DataMember]
        public int messageType { get; set; }
        [DataMember]
        public string subject { get; set; }
        [DataMember]
        public string body { get; set; }
        [DataMember]
        public List<RecipientEntity> recipientBOs { get; set; }

    }
    
}