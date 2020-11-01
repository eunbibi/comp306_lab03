using System;
using System.Collections.Generic;

namespace WebApp_Rds_Access.Models
{
    public partial class Course
    {
        public Course()
        {
            Enrollment = new HashSet<Enrollment>();
        }

        public string CourseCode { get; set; }
        public string CourseTitle { get; set; }
        public int TotalCourseHours { get; set; }
        public string School { get; set; }
        public string Department { get; set; }

        public virtual ICollection<Enrollment> Enrollment { get; set; }
    }
}
