using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp_MVC_L60_Join_DD_31523.Models
{
    public class tblRegistration 
    {
        [Key]

        [DisplayName("User ID")]
        public int rid { get; set; }


        [DisplayName("User Name")]
        [Required(ErrorMessage = "please enter your name")]
        public string Name { get; set; }

        [DisplayName("User Email")]
        [Required(ErrorMessage = "please enter your email")]
        public string Email { get; set; }

        [DisplayName("User Password")]
        [Required(ErrorMessage = "please enter your password")]
        public string Password { get; set; }

        [DisplayName("User Age")]
        [Required(ErrorMessage = "please enter your age")]
        public int Age { get; set; }

        [DisplayName("User Country")]
        [Required(ErrorMessage = "please select your country")]
        public int country { get; set; }
    }
}