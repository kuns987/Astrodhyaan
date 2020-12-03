using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Astrodhyaan.Models
{
    public class MailSettingEntity
    {
        [DataMember]
        public long mailId { get; set; }

        [DataMember]
        public string emailId { get; set; }

        [DataMember]
        public string password { get; set; }

        [DataMember]
        public string smtpPort { get; set; }


        [DataMember]
        public string smtpSocketFactoryPort { get; set; }

        [DataMember]
        public string smptSocketFactoryClass { get; set; }

        [DataMember]
        public string smptHost { get; set; }

        [DataMember]
        public bool? debug { get; set; }

        [DataMember]
        public bool? auth { get; set; }

        [DataMember]
        public bool? enableSSL { get; set; }

        [DataMember]
        public bool? socketFactoryFallBack { get; set; }

        [DataMember]
        public bool? sendMails { get; set; }

        [DataMember]
        public bool? enableTls { get; set; }
    }
}