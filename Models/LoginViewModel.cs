using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApp_Rds_Access.Models
{
    public partial class LoginViewModel
    {
/*
        [Required(ErrorMessage = "Please enter 1")]
        public string LoginName { get; set; }

        [Required(ErrorMessage = "Please enter 2")]
        public string Password { get; set; }
*/

        [Required(ErrorMessage = "Please enter 3")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter 4")]
        public string StudentPW { get; set; }

        //public virtual Students LoginNameNavigation { get; set; }
    }
}
