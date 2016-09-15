using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HBB_CMS.Areas.Admin.Models
{
    public class TermMeta
    {
        [Key]
        public Guid ID { get; set; }
        public String Key { get; set; }
        public String Value { get; set; }

        public virtual Term Term { set; get; }

    }
}