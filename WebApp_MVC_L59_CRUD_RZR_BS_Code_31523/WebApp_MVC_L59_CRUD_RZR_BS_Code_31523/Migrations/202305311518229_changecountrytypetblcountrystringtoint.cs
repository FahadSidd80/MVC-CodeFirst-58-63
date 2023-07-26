namespace WebApp_MVC_L59_CRUD_RZR_BS_Code_31523.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changecountrytypetblcountrystringtoint : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tblCountries", "cname", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tblCountries", "cname", c => c.Int(nullable: false));
        }
    }
}
