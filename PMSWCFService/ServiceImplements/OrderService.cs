﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PMSWCFService.DataContracts;
using PMSWCFService.ServiceContracts;
using AutoMapper;
using PMSDAL;
using PMSCommon;
using AuthorizationChecker;
using System.Data.Entity;

namespace PMSWCFService
{
    public partial class PMSService : IOrderService
    {
        /// <summary>
        /// 添加订单
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public int AddOrder(DcOrder order)
        {
            try
            {
                XS.RunLog();
                using (var dc = new PMSDbContext())
                {
                    int result = 0;
                    var config = new MapperConfiguration(cfg =>
                    {
                        cfg.CreateMap<DcOrder, PMSOrder>();
                    });
                    var mapper = config.CreateMapper();
                    var pmsOrder = mapper.Map<PMSOrder>(order);
                    dc.Orders.Add(pmsOrder);
                    result = dc.SaveChanges();
                    return result;
                }
            }
            catch (Exception ex)
            {
                XS.Current.Error(ex);
                throw ex;
            }

        }

        public int AddOrderByUID(DcOrder order, string uid)
        {
            try
            {
                XS.RunLog();
                using (var dc = new PMSDbContext())
                {
                    int result = 0;
                    var config = new MapperConfiguration(cfg =>
                    {
                        cfg.CreateMap<DcOrder, PMSOrder>();
                    });
                    var mapper = config.CreateMapper();
                    var pmsOrder = mapper.Map<PMSOrder>(order);
                    dc.Orders.Add(pmsOrder);
                    result = dc.SaveChanges();
                    SaveHistory(order, uid);
                    return result;
                }
            }
            catch (Exception ex)
            {
                XS.Current.Error(ex);
                throw ex;
            }
        }

        public bool CheckPMINumberExisit(string pminumber)
        {
            try
            {
                XS.RunLog();
                using (var dc = new PMSDbContext())
                {
                    var query = from i in dc.Orders
                                where i.PMINumber == pminumber && i.State != "作废"
                                select i;
                    return query.Count() > 0;
                }
            }
            catch (Exception ex)
            {
                XS.Current.Error(ex);
                throw ex;
            }
        }

        /// <summary>
        /// 删除订单
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeleteOrder(Guid id)
        {
            try
            {
                XS.RunLog();
                using (var dc = new PMSDbContext())
                {
                    int result = 0;
                    var pmsOrder = dc.Orders.Find(id);
                    if (pmsOrder != null)
                    {
                        pmsOrder.State = OrderState.作废.ToString();
                        dc.SaveChanges();
                    }
                    return result;
                }
            }
            catch (Exception ex)
            {
                XS.Current.Error(ex);
                throw ex;
            }
        }
        /// <summary>
        /// 获取全部订单
        /// </summary>
        /// <param name="skip"></param>
        /// <param name="take"></param>
        /// <returns></returns>
        public List<DcOrder> GetAllOrderInPage(int skip, int take)
        {
            XS.RunLog();

            try
            {
                using (var dc = new PMSDbContext())
                {
                    var config = new MapperConfiguration(cfg =>
                    {
                        cfg.CreateMap<PMSOrder, DcOrder>();
                    });
                    var mapper = config.CreateMapper();
                    var result = mapper.Map<List<PMSOrder>, List<DcOrder>>(
                        dc.Orders.OrderByDescending(o => o.CreateTime).Skip(skip).Take(take).ToList());
                    return result;
                }
            }
            catch (Exception ex)
            {
                XS.Current.Error(ex);
                throw ex;
            }
        }


        #region 过时
        /// <summary>
        /// 返回不包含删除标记的其他记录
        /// </summary>
        /// <param name="skip"></param>
        /// <param name="take"></param>
        /// <param name="customer"></param>
        /// <param name="compositionstd"></param>
        /// <returns></returns>
        public List<DcOrder> GetOrderBySearchInPage(int skip, int take, string customer, string compositionstd)
        {
            XS.RunLog();
            try
            {
                using (var dc = new PMSDbContext())
                {
                    var config = new MapperConfiguration(cfg =>
                    {
                        cfg.CreateMap<PMSOrder, DcOrder>();
                    });
                    var mapper = config.CreateMapper();
                    var query = from o in dc.Orders
                                where o.CustomerName.Contains(customer)
                                && o.CompositionStandard.Contains(compositionstd)
                                && o.State != OrderState.作废.ToString()
                                orderby o.CreateTime descending
                                select o;

                    var result = mapper.Map<List<PMSOrder>, List<DcOrder>>(query.Skip(skip).Take(take).ToList());
                    return result;
                }
            }
            catch (Exception ex)
            {
                XS.Current.Error(ex);
                throw ex;
            }
        }

        /// <summary>
        ///  获取搜索结果数量
        /// </summary>
        /// <param name="customer"></param>
        /// <param name="compositionstd"></param>
        /// <returns></returns>
        public int GetOrderCountBySearch(string customer, string compositionstd)
        {
            XS.RunLog();
            try
            {
                using (var dc = new PMSDbContext())
                {
                    return dc.Orders.Where(o => o.CustomerName.Contains(customer)
                    && o.CompositionStandard.Contains(compositionstd)
                    && o.State != OrderState.作废.ToString()).Count();
                }
            }
            catch (Exception ex)
            {
                XS.Current.Error(ex);
                throw ex;
            }

        }


        public List<DcOrder> GetOrderUnCompleted(int skip, int take, string customer, string compositionstd)
        {
            XS.RunLog();
            try
            {
                using (var dc = new PMSDbContext())
                {
                    var config = new MapperConfiguration(cfg =>
                    {
                        cfg.CreateMap<PMSOrder, DcOrder>();
                    });
                    var mapper = config.CreateMapper();
                    var query = from o in dc.Orders
                                where o.CustomerName.Contains(customer)
                                && o.CompositionStandard.Contains(compositionstd)
                                && (o.State == OrderState.未完成.ToString()
                                || o.State == OrderState.生产完成.ToString()
                                || o.State == OrderState.暂停.ToString()
                                || o.State == OrderState.未核验.ToString())
                                orderby o.Priority, o.CreateTime
                                select o;

                    var result = mapper.Map<List<PMSOrder>, List<DcOrder>>(query.Skip(skip).Take(take).ToList());
                    return result;
                }
            }
            catch (Exception ex)
            {
                XS.Current.Error(ex);
                throw ex;
            }
        }

        public int GetOrderCountUnCompleted(string customer, string compositionstd)
        {
            XS.RunLog();
            try
            {
                using (var dc = new PMSDbContext())
                {
                    return dc.Orders.Where(o => o.CustomerName.Contains(customer)
                    && o.CompositionStandard.Contains(compositionstd)
                     && (o.State == OrderState.未完成.ToString()
                                || o.State == OrderState.生产完成.ToString()
                                || o.State == OrderState.暂停.ToString()
                                || o.State == OrderState.未核验.ToString())).Count();
                }
            }
            catch (Exception ex)
            {
                XS.Current.Error(ex);
                throw ex;
            }
        }
        #endregion
        /// <summary>
        /// 返回不包含删除标记的其他记录
        /// </summary>
        /// <param name="skip"></param>
        /// <param name="take"></param>
        /// <param name="customer"></param>
        /// <param name="compositionstd"></param>
        /// <returns></returns>
        public List<DcOrder> GetOrders(int skip, int take, string customer, string compositionstd, string pminumber)
        {
            XS.RunLog();

            try
            {
                using (var dc = new PMSDbContext())
                {
                    var config = new MapperConfiguration(cfg =>
                    {
                        cfg.CreateMap<PMSOrder, DcOrder>();
                    });
                    var mapper = config.CreateMapper();
                    var query = from o in dc.Orders
                                where o.CustomerName.Contains(customer)
                                && o.CompositionStandard.Contains(compositionstd)
                                && o.PMINumber.Contains(pminumber)
                                && o.State != OrderState.作废.ToString()
                                orderby o.CreateTime descending
                                select o;

                    var result = mapper.Map<List<PMSOrder>, List<DcOrder>>(query.Skip(skip).Take(take).ToList());
                    return result;
                }
            }
            catch (Exception ex)
            {
                XS.Current.Error(ex);
                throw ex;
            }
        }

        /// <summary>
        ///  获取搜索结果数量
        /// </summary>
        /// <param name="customer"></param>
        /// <param name="compositionstd"></param>
        /// <returns></returns>
        public int GetOrderCount(string customer, string compositionstd, string pminumber)
        {
            XS.RunLog();

            try
            {
                using (var dc = new PMSDbContext())
                {
                    return dc.Orders.Where(o => o.CustomerName.Contains(customer)
                    && o.CompositionStandard.Contains(compositionstd)
                    && o.PMINumber.Contains(pminumber)
                    && o.State != OrderState.作废.ToString()).Count();
                }
            }
            catch (Exception ex)
            {
                XS.Current.Error(ex);
                throw ex;
            }

        }


        public List<DcOrder> GetOrderUnCompleted2(int skip, int take, string customer, string compositionstd, string pminumber)
        {
            XS.RunLog();
            try
            {
                using (var dc = new PMSDbContext())
                {
                    var config = new MapperConfiguration(cfg =>
                    {
                        cfg.CreateMap<PMSOrder, DcOrder>();
                    });
                    var mapper = config.CreateMapper();
                    var query = from o in dc.Orders
                                where o.CustomerName.Contains(customer)
                                && o.CompositionStandard.Contains(compositionstd)
                                && o.PMINumber.Contains(pminumber)
                                && (o.State == OrderState.未完成.ToString()
                                || o.State == OrderState.生产完成.ToString()
                                || o.State == OrderState.暂停.ToString()
                                || o.State == OrderState.未核验.ToString())
                                orderby o.Priority, o.CreateTime
                                select o;

                    var result = mapper.Map<List<PMSOrder>, List<DcOrder>>(query.Skip(skip).Take(take).ToList());
                    return result;
                }
            }
            catch (Exception ex)
            {
                XS.Current.Error(ex);
                throw ex;
            }
        }

        public int GetOrderCountUnCompleted2(string customer, string compositionstd, string pminumber)
        {
            XS.RunLog();
            try
            {
                using (var dc = new PMSDbContext())
                {
                    return dc.Orders.Where(o => o.CustomerName.Contains(customer)
                    && o.CompositionStandard.Contains(compositionstd)
                    && o.PMINumber.Contains(pminumber)
                     && (o.State == OrderState.未完成.ToString()
                                || o.State == OrderState.生产完成.ToString()
                                || o.State == OrderState.暂停.ToString()
                                || o.State == OrderState.未核验.ToString())).Count();
                }
            }
            catch (Exception ex)
            {
                XS.Current.Error(ex);
                throw ex;
            }
        }
        public int GetOrderCountByYear(int year)
        {
            try
            {
                XS.RunLog();
                var date = new DateTime(year, 1, 1);
                using (var dc = new PMSDbContext())
                {
                    var query = from o in dc.Orders
                                where o.State != OrderState.作废.ToString()
                                && DbFunctions.DiffYears(o.CreateTime, date) == 0
                                select o;
                    return query.Count();
                }
            }
            catch (Exception ex)
            {
                XS.Current.Error(ex);
                throw ex;
            }
        }

        public List<DcOrder> GetOrderByYear(int skip, int take, int year)
        {
            try
            {
                XS.RunLog();
                var date = new DateTime(year, 1, 1);
                using (var dc = new PMSDbContext())
                {
                    var config = new MapperConfiguration(cfg =>
                    {
                        cfg.CreateMap<PMSOrder, DcOrder>();
                    });
                    var mapper = config.CreateMapper();
                    var order = from o in dc.Orders
                                where o.State != OrderState.作废.ToString()
                                && DbFunctions.DiffYears(o.CreateTime, date) == 0
                                orderby o.CreateTime descending
                                select o;

                    var result = mapper.Map<List<PMSOrder>, List<DcOrder>>(order.Skip(skip).Take(take).ToList());
                    return result;
                }
            }
            catch (Exception ex)
            {
                XS.Current.Error(ex);
                throw ex;
            }
        }


        /// <summary>
        /// 更新订单
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public int UpdateOrder(DcOrder order)
        {
            try
            {
                XS.RunLog();
                using (var dc = new PMSDbContext())
                {
                    int result = 0;
                    var config = new MapperConfiguration(cfg =>
                    {
                        cfg.CreateMap<DcOrder, PMSOrder>();
                    });
                    var mapper = config.CreateMapper();
                    PMSOrder pmsOrder = mapper.Map<PMSOrder>(order);
                    dc.Entry(pmsOrder).State = System.Data.Entity.EntityState.Modified;
                    dc.SaveChanges();
                    return result;
                }
            }
            catch (Exception ex)
            {
                XS.Current.Error(ex);
                throw ex;
            }

        }

        public int UpdateOrderByUID(DcOrder order, string uid)
        {
            try
            {
                XS.RunLog();
                using (var dc = new PMSDbContext())
                {
                    int result = 0;
                    var config = new MapperConfiguration(cfg =>
                    {
                        cfg.CreateMap<DcOrder, PMSOrder>();
                    });
                    var mapper = config.CreateMapper();
                    PMSOrder pmsOrder = mapper.Map<PMSOrder>(order);
                    dc.Entry(pmsOrder).State = System.Data.Entity.EntityState.Modified;
                    dc.SaveChanges();

                    SaveHistory(order, uid);
                    return result;
                }
            }
            catch (Exception ex)
            {
                XS.Current.Error(ex);
                throw ex;
            }
        }
        private void SaveHistory(DcOrder model, string uid)
        {
            try
            {
                XS.RunLog();
                using (var dc = new PMSDbContext())
                {
                    var config = new MapperConfiguration(cfg =>
                    {
                        cfg.CreateMap<DcOrder, PMSOrderHistory>();
                    });
                    var mapper = config.CreateMapper();
                    var history = mapper.Map<PMSOrderHistory>(model);
                    history.OperateTime = DateTime.Now;
                    history.Operator = uid;
                    history.HistoryID = Guid.NewGuid();
                    dc.OrderHistorys.Add(history);
                    dc.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                XS.Current.Error(ex);
            }
        }


        //2017-8-31补充API
        public List<DcOrderHistory> GetOrderHistoryTop10(string pmiNumber)
        {
            XS.RunLog();
            throw new NotImplementedException();
        }

        public string GetOrderStatus()
        {
            XS.RunLog();
            throw new NotImplementedException();
        }

        public int GetOrderUnFinishedCount()
        {
            try
            {
                XS.RunLog();
                using (var dc = new PMSDbContext())
                {
                    var query = from o in dc.Orders
                                where o.State == OrderState.未完成.ToString()
                                select o;
                    return query.Count();
                }
            }
            catch (Exception ex)
            {
                XS.Current.Error(ex);
                throw ex;
            }
        }

        public double GetUnFinishedTargetCount()
        {
            try
            {
                XS.RunLog();
                using (var dc = new PMSDbContext())
                {
                    var query = from o in dc.Orders
                                where o.ProductType == "靶材" && (o.State == OrderState.未完成.ToString()
                                 || o.State == OrderState.未核验.ToString())
                                select o;
                    return query.Sum(i => i.Quantity);
                }
            }
            catch (Exception ex)
            {
                XS.Current.Error(ex);
                throw ex;
            }
        }

        public DcOrder GetOrderByPMINumber(string pminumber)
        {
            try
            {
                XS.RunLog();
                using (var dc = new PMSDbContext())
                {
                    var config = new MapperConfiguration(cfg =>
                    {
                        cfg.CreateMap<PMSOrder, DcOrder>();
                    });
                    var mapper = config.CreateMapper();
                    var result = mapper.Map<PMSOrder, DcOrder>(
                        dc.Orders.Where(i => i.PMINumber == pminumber).FirstOrDefault());
                    return result;
                }
            }
            catch (Exception ex)
            {
                XS.Current.Error(ex);
                throw ex;
            }
        }


    }
}