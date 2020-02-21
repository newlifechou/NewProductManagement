﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using PMSDAL;
using PMSWCFService.DataContracts;

namespace PMSWCFService.ServiceContracts
{
    [ServiceContract]
    public interface IToolSieveService
    {
        [OperationContract]
        List<DcToolSieve> GetToolSieve(string searchid,string materialGroup,int s,int t);
        [OperationContract]
        int GetToolSieveCount(string searchid, string materialGroup);

        [OperationContract]
        void AddToolSieve(DcToolSieve model);
        [OperationContract]
        void UpdateToolSieve(DcToolSieve model);
    }
}