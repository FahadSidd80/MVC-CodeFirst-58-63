namespace WebApp_MVC_L58_CodeBoot_31523.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createdatabaseandtable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblEmployees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        City = c.String(),
                        Salary = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tblEmployees");
        }
    }
}
