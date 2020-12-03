using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Astrodhyaan.Models
{
    public class APIResponseObjects
    {
    }
    public class AdminPageResponse
    {
        [DataMember]
        public int? exceptionId { get; set; }

        [DataMember]
        public string message { get; set; }

        [DataMember]
        public bool? exception { get; set; }
        [DataMember]
        public AdminPageEntity adminPageList { get; set; }
    }
    public class MobileHomeResponse
    {
        [DataMember]
        public int? exceptionId { get; set; }

        [DataMember]
        public string message { get; set; }

        [DataMember]
        public bool? exception { get; set; }
        [DataMember]
        public AdminPageEntity adminPageList { get; set; }
        [DataMember]
        public List<AstrologerEntity> astrologersList { get; set; }
        [DataMember]
        public UserMasterEntity UserDetail { get; set; }

    }
    public class GetCommonResponse
    {
        [DataMember]
        public int? exceptionId { get; set; }

        [DataMember]
        public string message { get; set; }

        [DataMember]
        public bool? exception { get; set; }

        [DataMember]
        public List<CommonEntity> commondataBOs { get; set; }

    }
    
    public class SaveMessageResponse
    {
        [DataMember]
        public int? exceptionId { get; set; }

        [DataMember]
        public string message { get; set; }

        [DataMember]
        public bool? exception { get; set; }        
    }    
}