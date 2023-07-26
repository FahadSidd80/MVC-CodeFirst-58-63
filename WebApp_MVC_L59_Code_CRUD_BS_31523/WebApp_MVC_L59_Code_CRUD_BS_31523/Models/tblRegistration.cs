using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp_MVC_L59_Code_CRUD_BS_31523.Models
{
    public class tblRegistration
    {
        [Key]
        public int rid { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public int age { get; set; }
    
    }
}