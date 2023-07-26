namespace WebApp_MVC_L58_CodeBoot_31523.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class altertable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tblEmployees", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.tblEmployees", "City", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tblEmployees", "City", c => c.String());
            AlterColumn("dbo.tblEmployees", "Name", c => c.String());
        }
    }
}
