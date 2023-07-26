using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp_MVC_L58_CodeBoot_31523.Models
{
    public class tblEmployee
    {
        [Key]
        [DisplayName("Emp ID")]
        public int Id { get; set; }

        [DisplayName("Emp Name")]
        [Required(ErrorMessage = "please enter your name !!")]
        public string Name { get; set; }

        [DisplayName("Emp City")]
        [Required(ErrorMessage = "please enter your city !!")]
        public string City { get; set; }

        [DisplayName("Emp Salary")]
        [Required(ErrorMessage = "please enter your salary !!")]
        public int Salary { get; set; }
    }
}