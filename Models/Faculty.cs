using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Error_Collage.Models
{
    public class Faculty
    {
        public virtual int FacultyId { get; set; }

        public virtual string FacultyName { get; set; }

        public virtual string TeachingFeild {get; set; }

        public virtual string Qualification { get; set; }

        public virtual string Deccription { get; set; }

        public virtual string Courseid { get; set; }

       

    }
}