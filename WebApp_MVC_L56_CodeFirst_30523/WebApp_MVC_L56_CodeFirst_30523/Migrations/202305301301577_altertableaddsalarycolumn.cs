namespace WebApp_MVC_L56_CodeFirst_30523.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class altertableaddsalarycolumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Registrations", "Salary", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Registrations", "Salary");
        }
    }
}
