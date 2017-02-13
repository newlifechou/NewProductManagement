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

        public int AddRole(DcUserRole model)
        {
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

        public int AddUser(DcUser model)
        {
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

        public bool CheckAccess(DcUser model, string AccessCode)
        {
            throw new NotImplementedException();
        }

        public bool CheckLogIn(DcUser model)
        {
            throw new NotImplementedException();
        }

        public bool CheckUserName(string userName)
        {
            throw new NotImplementedException();
        }

        public int DeleteAccess(Guid id)
        {
            using (var dc = new PMSDbContext())
            {
                int result = 0;


                return result;
            }
        }

        public int DeleteRole(Guid id)
        {
            using (var dc = new PMSDbContext())
            {
                int result = 0;


                return result;
            }
        }

        public int DeleteUser(Guid id)
        {
            using (var dc = new PMSDbContext())
            {
                int result = 0;


                return result;
            }
        }

        public List<DcUserAccess> GetAccessesByRoleId(Guid roleId)
        {
            throw new NotImplementedException();
        }

        public List<DcUserAccess> GetAllAccesses()
        {
            throw new NotImplementedException();
        }

        public List<DcUserRole> GetAllRoles()
        {
            throw new NotImplementedException();
        }

        public List<DcUser> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public DcUserRole GetRoleByUserId(Guid userId)
        {
            throw new NotImplementedException();
        }

        public int UpdateAccess(DcUserAccess model)
        {
            using (var dc = new PMSDbContext())
            {
                int result = 0;


                return result;
            }
        }

        public int UpdateRole(DcUserRole model)
        {
            using (var dc = new PMSDbContext())
            {
                int result = 0;


                return result;
            }
        }

        public int UpdateUser(DcUser model)
        {
            using (var dc = new PMSDbContext())
            {
                int result = 0;


                return result;
            }
        }
    }
}