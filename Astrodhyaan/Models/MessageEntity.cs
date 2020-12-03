using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;


namespace Astrodhyaan.Models
{
    [DataContract(IsReference = true)]
    public partial class MessageEntity
    {
                        
        [DataMember]
        public long messageId { get; set; }

        [DataMember]
        public long teamId { get; set; }

        [DataMember]
        public long senderId { get; set; }

        [DataMember]
        public int messageType { get; set; }

        [DataMember]
        public string body { get; set; }

        [DataMember]
        public string subject { get; set; }

        [DataMember]
        public string senderName { get; set; }

        [DataMember]
        public DateTime? createdDate { get; set; }

        [DataMember]
        public List<RecipientEntity> recipientList { get; set; }
    }
}