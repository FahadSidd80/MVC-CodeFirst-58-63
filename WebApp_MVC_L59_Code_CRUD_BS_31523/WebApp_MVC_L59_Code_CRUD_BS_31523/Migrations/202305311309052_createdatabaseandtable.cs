namespace WebApp_MVC_L59_Code_CRUD_BS_31523.Migrations
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
                        name = c.String(),
                        email = c.String(),
                        password = c.String(),
                        age = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.rid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tblRegistrations");
        }
    }
}
