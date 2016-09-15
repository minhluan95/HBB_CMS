using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HBB_CMS.Areas.Admin.Models
{
    public class UserMeta
    {
        [Key]
        public Guid ID { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public virtual User User { set; get; }
    }
}