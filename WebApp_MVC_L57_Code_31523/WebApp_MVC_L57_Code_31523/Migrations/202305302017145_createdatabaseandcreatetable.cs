namespace WebApp_MVC_L57_Code_31523.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createdatabaseandcreatetable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblEmployees",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Age = c.Int(nullable: false),
                        City = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tblEmployees");
        }
    }
}
