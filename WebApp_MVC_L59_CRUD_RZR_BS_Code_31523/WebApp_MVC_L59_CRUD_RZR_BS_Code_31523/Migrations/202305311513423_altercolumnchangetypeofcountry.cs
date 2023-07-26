namespace WebApp_MVC_L59_CRUD_RZR_BS_Code_31523.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class altercolumnchangetypeofcountry : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tblRegistrations", "country", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tblRegistrations", "country", c => c.Int(nullable: false));
        }
    }
}
