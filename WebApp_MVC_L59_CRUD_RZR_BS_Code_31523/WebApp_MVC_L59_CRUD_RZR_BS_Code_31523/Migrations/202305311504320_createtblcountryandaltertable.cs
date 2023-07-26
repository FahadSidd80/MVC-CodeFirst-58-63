namespace WebApp_MVC_L59_CRUD_RZR_BS_Code_31523.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createtblcountryandaltertable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblCountries",
                c => new
                    {
                        cid = c.Int(nullable: false, identity: true),
                        cname = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.cid);
            
            AddColumn("dbo.tblRegistrations", "country", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tblRegistrations", "country");
            DropTable("dbo.tblCountries");
        }
    }
}
