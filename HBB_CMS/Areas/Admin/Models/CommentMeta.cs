using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HBB_CMS.Areas.Admin.Models
{
    public class CommentMeta
    {
        [Key]
        public Guid ID { set; get; }
        public string Key { set; get; }
        public string Value { set; get; }

        public virtual Comment Comment { set; get; }
    }
}