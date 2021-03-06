﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSDAL
{
    public class User
    {
        public Guid ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }//密码必须MD5并加盐
        public DateTime CreateTime { get; set; }
        public string State { get; set; }//当前账户是否有效

        public string RealName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public Guid RoleID { get; set; }
    }
}
