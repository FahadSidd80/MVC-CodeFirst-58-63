using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;


namespace WebApp_MVC_L60_Join_DD_31523.Models
{
    public class Join 
    {

        [DisplayName("User Country")]
        public string Countryname { get; set; }

        [DisplayName("User ID")]
        public int rid { get; set; }

        [DisplayName("User Name")]
        public string Name { get; set; }

        [DisplayName("User Email")]
        public string Email { get; set; }

        [DisplayName("User Password")]
        public string Password { get; set; }

        [DisplayName("User Age")]
        public int Age { get; set; }
        public int country { get; set; }
    }
}