using System;
using System.Collections.Generic;

namespace WebApp_Rds_Access.Models
{
    public partial class Student
    {
        public Student()
        {
            Enrollment = new HashSet<Enrollment>();
        }

        public string StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Program { get; set; }

        public virtual Login Login { get; set; }
        public virtual ICollection<Enrollment> Enrollment { get; set; }
    }
}
