using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace WebApp_MVC_Code_L62_ChngePas_6123.Models
{
    public class ChangePassword
    {
        [DisplayName("Old Password")]
        public string OldPassword { get; set; }

        [DisplayName("New Password")]
        public string NewPassword { get; set; }

        [DisplayName("Confirm Password")]
        public string ConfirmPassword { get; set; }
    }
}