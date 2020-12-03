using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Astrodhyaan.Models
{
    [DataContract(IsReference = true)]
    public class UserDeviceEntity
    {
       

        [DataMember]
        public long Id { get; set; }
        [DataMember]
        public long UserId { get; set; }
        [DataMember]
        public string UserDeviceType { get; set; }
        [DataMember]
        public string UserDeviceKey { get; set; }
        [DataMember]
        public string Status { get; set; }
    }
}