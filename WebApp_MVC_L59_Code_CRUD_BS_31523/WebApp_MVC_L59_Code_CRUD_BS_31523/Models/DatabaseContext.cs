using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApp_MVC_L59_Code_CRUD_BS_31523.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("abc")
        {

        }
        public DbSet<tblRegistration> tblRegistrations { get; set; }
    }
}