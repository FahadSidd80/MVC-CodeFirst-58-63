namespace WebApp_MVC_L60_Join_DD_31523.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createdatabaseandtableregandcountrytable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblCountries",
                c => new
                    {
                        cid = c.Int(nullable: false, identity: true),
                        cname = c.String(),
                    })
                .PrimaryKey(t => t.cid);
            
            CreateTable(
                "dbo.tblRegistrations",
                c => new
                    {
                        rid = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        Age = c.Int(nullable: false),
                        country = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.rid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tblRegistrations");
            DropTable("dbo.tblCountries");
        }
    }
}
