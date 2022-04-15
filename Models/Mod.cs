using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Error_Collage.Models
{
    public class Mod
    {
        public virtual int ModuleId { get; set; }

        public virtual int CourseId { get; set; }

        public virtual string ModuleCode { get; set; }

        public virtual string ModuleTitle { get; set; }

        public virtual string Faculty { get; set; }

        public virtual string Content { get; set; }

        public virtual string Description { get; set; }
    }
}