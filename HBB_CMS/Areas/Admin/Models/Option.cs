using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HBB_CMS.Areas.Admin.Models
{
    public class Option
    {
        [Key]
        public Guid ID { get; set; }

        public String Name { get; set; }
        public String Value { get; set; }
        public String Autoload { get; set; }
    }
}