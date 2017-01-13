﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace PMSWCFService.DataContracts
{
    [DataContract]
    public class DcAccess
    {
        [DataMember]
        public Guid ID { get; set; }
        [DataMember]
        public string AccessName { get; set; }
        [DataMember]
        public string AccessCode { get; set; }
        [DataMember]
        public int State { get; set; }
        [DataMember]
        public string ExtraInformation { get; set; }
    }
}