using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Astrodhyaan.Models
{
    [DataContract(IsReference = true)]
    public class RecipientEntity
    {
        
        [DataMember]
        public long messageId { get; set; }

        [DataMember]
        public long recipientId { get; set; }

        [DataMember]
        public int status { get; set; }        

        [DataMember]
        public long userId { get; set; }

        [DataMember]
        public DateTime? createdDate { get; set; }
    }
}