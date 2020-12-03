using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Astrodhyaan.Models
{
    public class SettingsEntity
    {
        [DataMember]
        public long settingsId { get; set; }

        [DataMember]
        public string profileImagePath { get; set; }

        [DataMember]
        public string urlPath { get; set; }

        [DataMember]
        public string mail_Username { get; set; }

        [DataMember]
        public string mail_Password { get; set; }

        [DataMember]
        public string playerRegistrationContent { get; set; }

        [DataMember]
        public string coachRegistrationContent { get; set; }

        [DataMember]
        public MailSettingEntity mailsettings { get; set; }

    }
}