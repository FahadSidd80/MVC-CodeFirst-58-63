namespace WebApp_MVC_L56_CodeFirst_30523.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createtableemployeeagain : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        age = c.Int(nullable: false),
                        gender = c.Int(nullable: false),
                        address = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employees");
        }
    }
}
