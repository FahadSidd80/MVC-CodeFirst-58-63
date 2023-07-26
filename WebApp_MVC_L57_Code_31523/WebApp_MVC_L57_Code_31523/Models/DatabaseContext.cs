using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApp_MVC_L57_Code_31523.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("xyz")
        {

        }
        public DbSet<tblEmployee> tblEmployees { get; set; }
    }
}