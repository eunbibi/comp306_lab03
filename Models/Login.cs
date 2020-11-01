using System;
using System.Collections.Generic;

namespace WebApp_Rds_Access.Models
{
    public partial class Login
    {
        public string LoginName { get; set; }
        public string Password { get; set; }

        public virtual Student LoginNameNavigation { get; set; }
    }
}
