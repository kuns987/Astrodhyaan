using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;


namespace Astrodhyaan.Models
{
    [DataContract(IsReference = true)]
    public partial class ReminderEntity
    {
        
        [DataMember]
        public long scheduleId { get; set; }
        [DataMember]
        public long reminderId { get; set; }
        [DataMember]
        public long userId { get; set; }
        [DataMember]
        public int repeatType { get; set; }

        [DataMember]
        public int alertType { get; set; }

        [DataMember]
        public int secondAlert { get; set; }

        [DataMember]
        public DateTime? scheduledDate { get; set; }

        [DataMember]
        public DateTime? startDate { get; set; }

        [DataMember]
        public DateTime? endDate { get; set; }

        [DataMember]
        public DateTime? repeatDate { get; set; }

        [DataMember]
        public DateTime? endRepeatDate { get; set; }                
    }
}