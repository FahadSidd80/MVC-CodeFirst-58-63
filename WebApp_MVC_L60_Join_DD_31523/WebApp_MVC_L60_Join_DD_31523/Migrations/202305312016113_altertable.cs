namespace WebApp_MVC_L60_Join_DD_31523.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class altertable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tblRegistrations", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.tblRegistrations", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.tblRegistrations", "Password", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tblRegistrations", "Password", c => c.String());
            AlterColumn("dbo.tblRegistrations", "Email", c => c.String());
            AlterColumn("dbo.tblRegistrations", "Name", c => c.String());
        }
    }
}
