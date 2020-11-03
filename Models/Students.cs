using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_Rds_Access.Models
{
    public partial class Students
    {
        [Key]
        public int StudentId { get; set; }
        
        [Required(ErrorMessage ="Enter your First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Enter your Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Enter your Email Address")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Enter your pw")]
        public string StudentPW { get; set; }

    }
}
