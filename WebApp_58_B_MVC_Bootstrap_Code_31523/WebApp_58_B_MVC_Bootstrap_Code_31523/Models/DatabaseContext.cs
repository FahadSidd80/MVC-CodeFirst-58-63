using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApp_58_B_MVC_Bootstrap_Code_31523.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("abc")
        {

        }
        public DbSet<tblRegistration> tblRegistrations { get; set; }

    }
}