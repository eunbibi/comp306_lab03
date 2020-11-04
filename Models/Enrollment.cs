using System;
using System.Collections.Generic;

namespace WebApp_Rds_Access.Models
{
    public partial class Enrollment
    {
        public string StudentId { get; set; }
        public string CourseCode { get; set; }

        public virtual Course CourseCodeNavigation { get; set; }
        public virtual Students Student { get; set; }
    }
}
