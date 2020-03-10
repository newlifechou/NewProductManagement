﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using PMSWCFService.DataContracts;

namespace PMSWCFService.ServiceContracts
{
    [ServiceContract]
    public interface ISampleService
    {
        [OperationContract]
        List<DcSample> GetSample(int s, int t, string productid, string composition);

        [OperationContract]
        int GetSampleCount(string productid, string composition);


        [OperationContract]
        void AddSample(DcSample model);
        [OperationContract]
        void UpdateSample(DcSample model);
    }
}