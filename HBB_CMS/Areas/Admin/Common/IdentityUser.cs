using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;


namespace HBB_CMS.Areas.Admin.Common
{
    public class IdentityUser : IUser<int>
    {
        public IdentityUser()
        {

        }
        public IdentityUser(string userName, string passWord)
        {
            this.UserName = userName;
            this.Password = passWord;
        }
        public int Id { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
    }
}