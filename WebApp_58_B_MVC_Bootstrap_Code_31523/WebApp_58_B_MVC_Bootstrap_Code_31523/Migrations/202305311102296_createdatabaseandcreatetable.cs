namespace WebApp_58_B_MVC_Bootstrap_Code_31523.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createdatabaseandcreatetable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblRegistrations",
                c => new
                    {
                        rid = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        Password = c.Int(nullable: false),
                        Age = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.rid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tblRegistrations");
        }
    }
}
