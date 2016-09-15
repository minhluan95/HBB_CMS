using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HBB_CMS.Areas.Admin.Models
{
    public class Link
    {
        [Key]
        public Guid ID { set; get; }
        public string Url { set; get; }
        public string Name { set; get; }
        public string Image { set; get; }
        public string Target { set; get; }
        public string Description { set; get; }
        public string Visible { set; get; }
        public Guid Owner { set; get; }
        public int Rating { set; get; }
        public DateTime Updated { set; get; }
        public string Rel { set; get; }
        public string Notes { set; get; }
        public string Rss { set; get; }
    }
}