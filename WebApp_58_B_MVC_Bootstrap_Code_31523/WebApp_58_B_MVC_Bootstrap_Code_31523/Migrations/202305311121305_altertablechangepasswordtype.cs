namespace WebApp_58_B_MVC_Bootstrap_Code_31523.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class altertablechangepasswordtype : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tblRegistrations", "Password", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tblRegistrations", "Password", c => c.Int(nullable: false));
        }
    }
}
