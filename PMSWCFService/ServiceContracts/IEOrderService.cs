﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace PMSWCFService.ServiceContracts
{
    [ServiceContract]
    public interface IEOrderService
    {
        [OperationContract]
        bool CheckEOrderGuid(string guidid);
    }
}
