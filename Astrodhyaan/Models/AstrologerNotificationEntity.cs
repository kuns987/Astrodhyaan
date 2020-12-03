using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;


namespace Astrodhyaan.Models
{
    [DataContract(IsReference = true)]
    public partial class AstrologerNotificationEntity
    {
        
        [DataMember]
        public long Id { get; set; }
        [DataMember]
        public long AstroId { get; set; }
        [DataMember]
        public string NotificationMessage { get; set; }
        [DataMember]
        public string Status { get; set; }
    }
}