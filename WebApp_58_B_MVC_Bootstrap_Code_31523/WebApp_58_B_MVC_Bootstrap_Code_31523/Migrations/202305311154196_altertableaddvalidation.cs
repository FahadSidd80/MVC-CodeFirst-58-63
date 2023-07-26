namespace WebApp_58_B_MVC_Bootstrap_Code_31523.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class altertableaddvalidation : DbMigration
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
