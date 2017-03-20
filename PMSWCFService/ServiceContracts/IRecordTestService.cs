﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PMSWCFService.DataContracts;
using System.ServiceModel;

namespace PMSWCFService.ServiceContracts
{
    [ServiceContract]
    public interface IRecordTestService
    {
        [OperationContract]
        List<DcRecordTest> GetRecordTestBySearchInPage(int skip, int take, string productId, string compositionStd);
        [OperationContract]
        int GetRecordTestCountBySearchInPage(string productId, string compositionStd);
        [OperationContract]
        int AddRecordTest(DcRecordTest model);
        [OperationContract]
        int UpdateRecordTest(DcRecordTest model);
        [OperationContract]
        int DeleteRecordTest(Guid id);
    }
}