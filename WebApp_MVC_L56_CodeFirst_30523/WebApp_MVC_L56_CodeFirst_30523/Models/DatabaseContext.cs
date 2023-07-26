using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApp_MVC_L56_CodeFirst_30523.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("abc")
        {

        }
        public DbSet<Registration> Registrations { get; set; }// Registrations is table name  // Registration is table class

        public DbSet<Employee> Employees { get; set; }
    }
}