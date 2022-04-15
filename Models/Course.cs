using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Error_Collage.Models
{
    public class Course
    {
        public virtual int CourseId { get; set; }

        public virtual string CourseName { get; set; }
    
        public virtual string CourseCode { get; set; }

        public virtual string CourseFeildType { get; set; }

        public virtual string CourseType { get; set; }

        public virtual string Faculty { get; set; }

        public virtual string CourseDescription { get; set; }
    }
}