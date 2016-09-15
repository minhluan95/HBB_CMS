using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HBB_CMS.Areas.Admin.Models
{
    public class Comment
    {
        [Key]
        public Guid ID { get; set; }
        public Guid PostId  { get; set; }
        public string Author { get; set; }
        public string AuthorEmail { get; set; }
        public string AuthorUrl { get; set; }
        public string AuthorIp { get; set; }
        public DateTime Date { get; set; }
        public DateTime Date_gmt { get; set; }
        public string Content { get; set; }
        public int Karma { get; set; }
        public string Approved { get; set; }
        public string Agent { get; set; }
        public string Type { get; set; }
        public Guid Patent { get; set; }

        public virtual User User { set; get; }
        public virtual ICollection<CommentMeta> CommentMetas { get; set; }

    }
}