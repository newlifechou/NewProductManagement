﻿using PMSWCFService.DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace PMSWCFService.ServiceContracts
{
    /// <summary>
    /// 综合查询类
    /// </summary>
    [ServiceContract]
    public interface IComplexQuery
    {
        /// <summary>
        /// 通过内部编号来查询进度
        /// </summary>
        /// <param name="pmiNumber"></param>
        /// <returns></returns>
        [OperationContract]
        List<DcComplexQueryResult> GetAllStatusByPMINumber(string pmiNumber);
        
        /// <summary>
        ///通过计划编号来查询进度 
        /// </summary>
        /// <param name="planNumber"></param>
        /// <returns></returns>
        [OperationContract]
        List<DcComplexQueryResult> GetAllStatusByPlanNumber(string planNumber);

    }
}
