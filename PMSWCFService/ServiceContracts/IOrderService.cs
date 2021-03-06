﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;
using PMSWCFService.DataContracts;

namespace PMSWCFService.ServiceContracts
{
    [ServiceContract]
    public interface IOrderService
    {
        [OperationContract]
        List<DcOrder> GetAllOrderInPage(int skip, int take);
        #region 过时
        [OperationContract]
        List<DcOrder> GetOrderBySearchInPage(int skip, int take, string customer, string compositionstd);
        [OperationContract]
        int GetOrderCountBySearch(string customer, string compositionstd);

        [OperationContract]
        List<DcOrder> GetOrderUnCompleted(int skip, int take, string customer, string compositionstd);
        [OperationContract]
        int GetOrderCountUnCompleted(string customer, string compositionstd);
        #endregion

        [OperationContract]
        List<DcOrder> GetOrders(int skip, int take, string customer, string compositionstd, string pminumber);
        [OperationContract]
        int GetOrderCount(string customer, string compositionstd, string pminumber);

        [OperationContract]
        List<DcOrder> GetOrderUnCompleted2(int skip, int take, string customer, string compositionstd, string pminumber);
        [OperationContract]
        int GetOrderCountUnCompleted2(string customer, string compositionstd, string pminumber);


        [OperationContract]
        List<DcOrder> GetOrderByYear(int skip, int take, int year);
        [OperationContract]
        int GetOrderCountByYear(int year);

        [OperationContract]
        int AddOrder(DcOrder order);
        [OperationContract]
        int AddOrderByUID(DcOrder order, string uid);
        [OperationContract]
        int UpdateOrder(DcOrder order);
        [OperationContract]
        int UpdateOrderByUID(DcOrder order, string uid);
        [OperationContract]
        int DeleteOrder(Guid id);


        [OperationContract]
        bool CheckPMINumberExisit(string pminumber);

        [OperationContract]
        List<DcOrderHistory> GetOrderHistoryTop10(string pmiNumber);


        [OperationContract]
        string GetOrderStatus();

        [OperationContract]
        int GetOrderUnFinishedCount();

        [OperationContract]
        double GetUnFinishedTargetCount();


        [OperationContract]
        DcOrder GetOrderByPMINumber(string pminumber);

    }
}