﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PMSWCFService.DataContracts
{
    [DataContract]
    public class DcBDVHPMold
    {
        [DataMember]
        public Guid ID { get; set; }
        [DataMember]
        public string MoldName { get; set; }
        [DataMember]
        public string MoldType { get; set; }
        [DataMember]
        public string MoldDetails { get; set; }
        [DataMember]
        public double InnerDiameter { get; set; }
        [DataMember]
        public double ModelHeight { get; set; }
        [DataMember]
        public DateTime StartTime { get; set; }
        [DataMember]
        public int EstimateUsedCount { get; set; }
        [DataMember]
        public int CurrentUsedCount { get; set; }
        [DataMember]
        public string State { get; set; }
        [DataMember]
        public string Creator { get; set; }
        [DataMember]
        public DateTime CreateTime { get; set; }

    }

}
