using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HBB_CMS.Areas.Admin.Models
{
    public class Term
    {
        [Key]
        public Guid ID { get; set; }
        public String Name { get; set; }
        public String Slug { get; set; }
        public Guid Group { get; set; }

        public virtual ICollection<TermMeta> TermMetas { get; set; }
        public virtual ICollection<Term_Taxonomy> Term_Taxonomys { get; set; }
    }
}