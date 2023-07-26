using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp_MVC_L56_CodeFirst_30523.Models
{
    public class Employee
    {

        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public int age { get; set; } 
        public int gender { get; set; }
        public string address { get; set; }

    }
}