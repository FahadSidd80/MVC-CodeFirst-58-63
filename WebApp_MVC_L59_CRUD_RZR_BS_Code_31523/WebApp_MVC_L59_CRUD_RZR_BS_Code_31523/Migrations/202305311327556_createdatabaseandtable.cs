namespace WebApp_MVC_L59_CRUD_RZR_BS_Code_31523.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createdatabaseandtable : DbMigration
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
                        Password = c.String(),
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
