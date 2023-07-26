using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApp_MVC_L59_CRUD_RZR_BS_Code_31523.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() :base("abc")
        {

        }
        public DbSet<tblRegistration> tblRegistrations { get; set; }
        public DbSet<tblCountry> tblCountries { get; set; }
    }
}