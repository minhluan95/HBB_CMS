using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HBB_CMS.Areas.Admin.Models
{
    public class User
    {
        [Key]
        public Guid ID { get; set; }
        public string Login { get; set; }
        public string Pass { get; set; }
        public string NiceName { get; set; }
        public string Email { get; set; }
        public string Url { get; set; }
        public DateTime Registered { get; set; }
        public string ActivationKey { get; set; }
        public int Status { set; get; }
        public string DisplayName { get; set; }

        public virtual ICollection<UserMeta> UserMetas { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
    }
}