using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HBB_CMS.Areas.Admin.Models
{
    public class Post
    {
        [Key]
        public Guid ID { set; get; }
        public DateTime Date { set; get; }
        public DateTime Date_gmt { set; get; }
        public string Content { set; get; }
        public string Title { set; get; }
        public string Except { set; get; }
        public string Status { set; get; }
        public string CommentStatus { set; get; }
        public string PingStatus { set; get; }
        public string Password { set; get; }
        public string Name { set; get; }
        public string ToPing { set; get; }
        public string Pinged { set; get; }
        public DateTime Modified { set; get; }
        public DateTime Modified_gmt { set; get; }
        public string ContentFiltered { set; get; }
        public Guid Parent { set; get; }
        public string Guid { set; get; }
        public int MenuOrder { set; get; }
        public string Type { set; get; }
        public string MimeType { set; get; }
        public Guid CommentCount { set; get; }

        public virtual ICollection<PostMeta> PostMetas { get; set; }
        public virtual ICollection<Term_Relationship> Term_Relationships { get; set; }
        public virtual User User { set; get; }


    }
}