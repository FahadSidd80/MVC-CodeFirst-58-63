using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp_MVC_Code_L62_ChngePas_6123.Models
{
    public class tblCountry
    {
        [Key]
        public int cid { get; set; }
        public string cname { get; set; }
    }
}