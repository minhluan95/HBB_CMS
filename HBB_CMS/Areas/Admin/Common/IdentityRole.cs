using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;

namespace HBB_CMS.Areas.Admin.Common
{
    public class IdentityRole : IRole<int>
    {
        public IdentityRole() {  }
        public IdentityRole(string roleName) {
            this.Name = roleName;
        }
        public int Id { get; set; }
        public string Name { get; set; }
    }
}