﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PMSDAL;
using PMSWCFService.DataContracts;
using PMSWCFService.ServiceContracts;
using AutoMapper;
using PMSWCFService.ServiceImplements.Helpers;
using System.Text;

namespace PMSWCFService
{
    public class ToolService : IToolSieveService
    {
        public void AddToolSieve(DcToolSieve model)
        {
            try
            {
                XS.RunLog();
                using (var dc = new PMSDbContext())
                {
                    Mapper.Initialize(cfg => cfg.CreateMap<DcToolSieve, ToolSieve>());
                    var entity = Mapper.Map<ToolSieve>(model);
                    dc.ToolSieves.Add(entity);
                    dc.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                XS.Current.Error(ex);
                throw ex;
            }
        }

        public int CheckToolSieveExist(string searchid)
        {
            try
            {
                XS.RunLog();
                using (var dc = new PMSDbContext())
                {
                    var query = from i in dc.ToolSieves
                                where (i.State == PMSCommon.ToolState.正常.ToString()
                                || i.State == PMSCommon.ToolState.停止使用.ToString())
                                && i.SearchID == searchid
                                select i;
                    return query.Count();
                }
            }
            catch (Exception ex)
            {
                XS.Current.Error(ex);
                throw ex;
            }
        }
        public int CheckToolMillingBoxExist(string boxnumber)
        {
            try
            {
                XS.RunLog();
                using (var dc = new PMSDbContext())
                {
                    var query = from i in dc.ToolSieves
                                where i.State != PMSCommon.ToolState.作废.ToString()
                                && i.BoxNumber == boxnumber
                                select i;
                    return query.Count();
                }
            }
            catch (Exception ex)
            {
                XS.Current.Error(ex);
                throw ex;
            }
        }
        public List<DcToolSieve> GetToolSieve(string boxnumber, string searchid, string materialGroup, int s, int t)
        {
            try
            {

                XS.RunLog();
                var searchItem = CompositionHelper.GetSearchItems(materialGroup);
                using (var dc = new PMSDbContext())
                {
                    Mapper.Initialize(cfg => cfg.CreateMap<ToolSieve, DcToolSieve>());
                    var query = from i in dc.ToolSieves
                                where (i.State == PMSCommon.ToolState.正常.ToString()
                                || i.State == PMSCommon.ToolState.停止使用.ToString())
                                && i.SearchID.Contains(searchid)
                                && i.BoxNumber.Contains(boxnumber)
                                && i.MaterialGroup.Contains(searchItem.Item1)
                                && i.MaterialGroup.Contains(searchItem.Item2)
                                && i.MaterialGroup.Contains(searchItem.Item3)
                                && i.MaterialGroup.Contains(searchItem.Item4)
                                orderby i.BoxNumber.Length descending, i.BoxNumber descending, i.CreateTime descending
                                select i;
                    return Mapper.Map<List<ToolSieve>, List<DcToolSieve>>(query.Skip(s).Take(t).ToList());
                }
            }
            catch (Exception ex)
            {
                XS.Current.Error(ex);
                throw ex;
            }
        }

        public int GetToolSieveCount(string boxnumber, string searchid, string materialGroup)
        {
            try
            {
                XS.RunLog();
                var searchItem = CompositionHelper.GetSearchItems(materialGroup);
                using (var dc = new PMSDbContext())
                {
                    var query = from i in dc.ToolSieves
                                where (i.State == PMSCommon.ToolState.正常.ToString()
                                || i.State == PMSCommon.ToolState.停止使用.ToString())
                                && i.SearchID.Contains(searchid)
                                && i.BoxNumber.Contains(boxnumber)
                                && i.MaterialGroup.Contains(searchItem.Item1)
                                && i.MaterialGroup.Contains(searchItem.Item2)
                                && i.MaterialGroup.Contains(searchItem.Item3)
                                && i.MaterialGroup.Contains(searchItem.Item4)
                                select i;
                    return query.Count();
                }
            }
            catch (Exception ex)
            {
                XS.Current.Error(ex);
                throw ex;
            }
        }

        public List<DcToolSieve> GetToolSieveUsed(string boxnumber, string searchid, string materialGroup, int s, int t)
        {
            try
            {
                XS.RunLog();
                var searchItem = CompositionHelper.GetSearchItems(materialGroup);
                using (var dc = new PMSDbContext())
                {
                    Mapper.Initialize(cfg => cfg.CreateMap<ToolSieve, DcToolSieve>());
                    var query = from i in dc.ToolSieves
                                where i.State == PMSCommon.ToolState.正常.ToString()
                                && i.SearchID.Contains(searchid)
                                && i.BoxNumber.Contains(boxnumber)
                                && i.MaterialGroup.Contains(searchItem.Item1)
                                && i.MaterialGroup.Contains(searchItem.Item2)
                                && i.MaterialGroup.Contains(searchItem.Item3)
                                && i.MaterialGroup.Contains(searchItem.Item4)
                                orderby i.BoxNumber.Length descending, i.BoxNumber descending, i.CreateTime descending
                                select i;
                    return Mapper.Map<List<ToolSieve>, List<DcToolSieve>>(query.Skip(s).Take(t).ToList());
                }
            }
            catch (Exception ex)
            {
                XS.Current.Error(ex);
                throw ex;
            }
        }

        public int GetToolSieveUsedCount(string boxnumber, string searchid, string materialGroup)
        {
            try
            {
                XS.RunLog();
                var searchItem = CompositionHelper.GetSearchItems(materialGroup);
                using (var dc = new PMSDbContext())
                {
                    var query = from i in dc.ToolSieves
                                where i.State == PMSCommon.ToolState.正常.ToString()
                                && i.SearchID.Contains(searchid)
                                && i.BoxNumber.Contains(boxnumber)
                                && i.MaterialGroup.Contains(searchItem.Item1)
                                && i.MaterialGroup.Contains(searchItem.Item2)
                                && i.MaterialGroup.Contains(searchItem.Item3)
                                && i.MaterialGroup.Contains(searchItem.Item4)
                                orderby i.CreateTime descending
                                select i;
                    return query.Count();
                }
            }
            catch (Exception ex)
            {
                XS.Current.Error(ex);
                throw ex;
            }
        }

        public void UpdateToolSieve(DcToolSieve model)
        {
            try
            {
                XS.RunLog();
                using (var dc = new PMSDbContext())
                {
                    Mapper.Initialize(cfg => cfg.CreateMap<DcToolSieve, ToolSieve>());
                    var entity = Mapper.Map<ToolSieve>(model);
                    dc.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                    dc.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                XS.Current.Error(ex);
                throw ex;
            }
        }

        public string GetMaxToolSieveNumber()
        {
            try
            {
                XS.RunLog();
                using (var dc = new PMSDbContext())
                {
                    var query = from i in dc.ToolSieves
                                where i.State != PMSCommon.ToolState.作废.ToString()
                                orderby i.SearchID.Length descending, i.SearchID descending
                                select i;

                    int count = 0;
                    StringBuilder sb = new StringBuilder();
                    foreach (var item in query)
                    {
                        sb.Append(item.SearchID);
                        sb.Append(";");
                        count++;
                        if (count > 4)
                        {
                            break;
                        }
                    }
                    return sb.ToString();
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