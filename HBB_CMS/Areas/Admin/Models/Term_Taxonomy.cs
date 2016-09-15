using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HBB_CMS.Areas.Admin.Models
{
    public class Term_Taxonomy
    {
        [Key]
        public Guid ID { get; set; }
        public String Taxonomy { get; set; }
        public String Description { get; set; }
        public Guid Parent { get; set; }
        public Guid Count { get; set; }

        public virtual Term Term { get; set; }
        public virtual Term_Relationship Term_Relationships { get; set; }
    }
}