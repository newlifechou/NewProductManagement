﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PMSWCFService.DataContracts;
using PMSWCFService.ServiceContracts;
using PMSDAL;
using System.Data.Entity;

namespace PMSWCFService
{
    public class PMSIndexService : IPMSIndexService
    {
        public void CalculateMaterialIndex(Guid orderid)
        {
            try
            {
                using (var dc = new PMSDbContext())
                {
                    var currentOrder = dc.Orders.Find(orderid);
                    if (currentOrder != null)
                    {
                        string pminumber = currentOrder.PMINumber;
                        double materialWeight = dc.MaterialOrderItems.Where(i => i.PMINumber.Contains(pminumber)).Sum(i => i.Weight);
                        double materialIndex = materialWeight / currentOrder.Quantity;

                        currentOrder.MaterialIndex = materialIndex;

                        dc.Entry(currentOrder).State = EntityState.Modified;
                        dc.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                LocalService.CurrentLog.Error(ex);
            }
        }

        public void CalculateProductionIndex(Guid orderid)
        {
            try
            {
                using (var dc = new PMSDbContext())
                {
                    double planCount = dc.VHPPlans.Where(i => i.OrderID == orderid).Count();
                    double targetCount = 0;
                    var currentOrder = dc.Orders.Find(orderid);
                    if (currentOrder != null)
                    {
                        targetCount = currentOrder.Quantity;
                        double productIndex = 0;
                        if (targetCount > 0)
                        {
                            productIndex = planCount / targetCount;
                        }
                        //设置值并保存
                        currentOrder.ProductionIndex = productIndex;
                        dc.Entry(currentOrder).State = EntityState.Modified;
                        dc.SaveChanges();
                    }


                }
            }
            catch (Exception ex)
            {
                LocalService.CurrentLog.Error(ex);
                throw ex;
            }
        }
    }
}