using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp_MVC_L63_DB_Apprch_Mstr_2623.Models
{
    public class Login
    {
        [DisplayName("UserType")]
        [Required(ErrorMessage = "Please select User type..!!")]
        public int login_UserType { get; set; }
        [DisplayName("Email ID")]
        [Required(ErrorMessage = "Please enter email id..!!")]

        public string login_email { get; set; }
        [DisplayName("Password")]
        [Required(ErrorMessage = "Please enter password..!!")]

        public string login_password { get; set; }
    }
}