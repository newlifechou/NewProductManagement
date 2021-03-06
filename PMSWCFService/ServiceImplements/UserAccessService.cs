﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PMSWCFService.DataContracts;
using PMSWCFService.ServiceContracts;
using AutoMapper;
using PMSDAL;

namespace PMSWCFService
{
    public class UserAccessService : IUserAccessService
    {
        public int AddAccess(DcUserAccess model)
        {
            try
            {
                XS.RunLog();
                using (var dc = new PMSDbContext())
                {
                    int result = 0;
                    var config = new MapperConfiguration(cfg => cfg.CreateMap<DcUserAccess, UserAccess>());
                    var mapper = config.CreateMapper();
                    var access = mapper.Map<UserAccess>(model);
                    dc.Accesses.Add(access);
                    result = dc.SaveChanges();
                    return result;
                }
            }
            catch (Exception ex)
            {
                XS.Current.Error(ex);
                return 0;
            }
        }

        public int AddRole(DcUserRole model)
        {
            try
            {
                XS.RunLog();
                using (var dc = new PMSDbContext())
                {
                    int result = 0;
                    var config = new MapperConfiguration(cfg => cfg.CreateMap<DcUserRole, UserRole>());
                    var mapper = config.CreateMapper();
                    var role = mapper.Map<UserRole>(model);
                    dc.Roles.Add(role);
                    result = dc.SaveChanges();
                    return result;
                }
            }
            catch (Exception ex)
            {
                XS.Current.Error(ex);
                return 0;
            }

        }

        public int AddUser(DcUser model)
        {
            try
            {
                XS.RunLog();
                using (var dc = new PMSDbContext())
                {
                    int result = 0;
                    var config = new MapperConfiguration(cfg => cfg.CreateMap<DcUserAccess, UserAccess>());
                    var mapper = config.CreateMapper();
                    var access = mapper.Map<UserAccess>(model);
                    dc.Accesses.Add(access);
                    result = dc.SaveChanges();
                    return result;
                }
            }
            catch (Exception ex)
            {
                XS.Current.Error(ex);
                return 0;
            }

        }

        public int DeleteAccess(Guid id)
        {

            try
            {
                XS.RunLog();
                using (var dc = new PMSDbContext())
                {
                    int result = 0;


                    return result;
                }
            }
            catch (Exception ex)
            {
                XS.Current.Error(ex);
                return 0;
            }

        }

        public int DeleteRole(Guid id)
        {
            try
            {
                XS.RunLog();
                using (var dc = new PMSDbContext())
                {
                    int result = 0;


                    return result;
                }
            }
            catch (Exception ex)
            {
                XS.Current.Error(ex);
                return 0;
            }

        }

        public int DeleteUser(Guid id)
        {
            try
            {
                XS.RunLog();
                using (var dc = new PMSDbContext())
                {
                    int result = 0;


                    return result;
                }
            }
            catch (Exception ex)
            {
                XS.Current.Error(ex);
                return 0;
            }

        }
        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public DcUser GetUser(string username, string password)
        {
            try
            {
                XS.RunLog();
                using (var dc = new PMSDbContext())
                {
                    Mapper.Initialize(cfg => cfg.CreateMap<User, DcUser>());
                    var user = dc.Users.Where(i => i.UserName == username
                    && i.Password == password
                    && i.State == PMSCommon.UserState.雇佣.ToString()).FirstOrDefault();
                    return Mapper.Map<DcUser>(user);
                }
            }
            catch (Exception ex)
            {
                XS.Current.Error(ex);
                return null;
            }
        }
        /// <summary>
        /// 检查用户名是否存在
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public bool IsUserNameExsit(string userName)
        {
            try
            {
                XS.RunLog();
                using (var dc = new PMSDbContext())
                {
                    var count = dc.Users.Where(i => i.UserName == userName).Count();
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                XS.Current.Error(ex);
                return false;
            }
        }

        public DcUserRole GetRole(Guid roleId)
        {
            try
            {
                XS.RunLog();
                using (var dc = new PMSDbContext())
                {
                    var role = dc.Roles.Where(i => i.ID == roleId).FirstOrDefault();
                    Mapper.Initialize(cfg => cfg.CreateMap<UserRole, DcUserRole>());
                    return Mapper.Map<DcUserRole>(role);
                }
            }
            catch (Exception ex)
            {
                XS.Current.Error(ex);
                return null;
            }
        }

        public List<DcUserAccess> GetAccesses(Guid roleId)
        {
            try
            {
                XS.RunLog();
                using (var dc = new PMSDbContext())
                {
                    var role = dc.Roles.Where(i => i.ID == roleId).FirstOrDefault();
                    if (role != null)
                    {
                        Mapper.Initialize(cfg => cfg.CreateMap<UserAccess, DcUserAccess>());
                        return Mapper.Map<List<UserAccess>, List<DcUserAccess>>(role.UserAccesses);
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                XS.Current.Error(ex);
                return null;
            }
        }

        public List<DcUserAccess> GetAllAccesses()
        {
            try
            {
                XS.RunLog();
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                XS.Current.Error(ex);
                return null;
            }

        }

        public List<DcUserRole> GetAllRoles()
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                XS.Current.Error(ex);
                return null;
            }

        }

        public List<DcUser> GetAllUsers()
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                XS.Current.Error(ex);
                return null;
            }

        }



        public int UpdateAccess(DcUserAccess model)
        {
            try
            {
                using (var dc = new PMSDbContext())
                {
                    int result = 0;


                    return result;
                }
            }
            catch (Exception ex)
            {
                XS.Current.Error(ex);
                return 0;
            }

        }

        public int UpdateRole(DcUserRole model)
        {
            try
            {
                using (var dc = new PMSDbContext())
                {
                    int result = 0;


                    return result;
                }
            }
            catch (Exception ex)
            {
                XS.Current.Error(ex);
                return 0;
            }

        }

        public int UpdateUser(DcUser model)
        {
            try
            {
                using (var dc = new PMSDbContext())
                {
                    int result = 0;


                    return result;
                }
            }
            catch (Exception ex)
            {
                XS.Current.Error(ex);
                return 0;
            }
        }
    }
}