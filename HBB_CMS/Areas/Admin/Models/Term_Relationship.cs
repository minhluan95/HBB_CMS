using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HBB_CMS.Areas.Admin.Models
{
    public class Term_Relationship
    {
        [Key]
        public Guid ID { get; set; }
        public int Order { get; set; }
        
        public virtual ICollection<Term_Taxonomy> Term_Taxonomys { get; set; }
        public virtual Post Post { get; set; }
    }
}