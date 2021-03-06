﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMSWCFService.DataContracts;
using System.ServiceModel;

namespace PMSWCFService.ServiceContracts
{
    [ServiceContract]
    public interface IRecordMillingService
    {
        [OperationContract]
        List<DcRecordMilling> GetRecordMillings(int skip, int take);
        [OperationContract]
        int GetRecordMillingCount();
        [OperationContract]
        List<DcRecordMilling> GetRecordMillingsByVHPPlanLot(int skip, int take, string vhpplanlot, string composition);
        [OperationContract]
        int GetRecordMillingCountByVHPPlanLot(string vhpplanlot, string composition);

        [OperationContract]
        List<DcRecordMilling> GetRecordMillingByMaterialType(string materialType, int topCount);

        [OperationContract]
        int AddRecordMilling(DcRecordMilling model);
        [OperationContract]
        int UpdateRecordMilling(DcRecordMilling model);
        [OperationContract]
        int AddRecordMillingByUID(DcRecordMilling model, string uid);
        [OperationContract]
        int UpdateRecordMillingByUID(DcRecordMilling model, string uid);
        [OperationContract]
        int DeleteRecordMilling(Guid id);



        [OperationContract]
        double GetAllPowderWeight();


        //用于集成查询功能
        [OperationContract]
        List<DcRecordMilling> GetRecordMillingsByPMINumber(string pminumber);

    }
}
