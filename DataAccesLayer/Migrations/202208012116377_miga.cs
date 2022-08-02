namespace DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class miga : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contact2",
                c => new
                    {
                        ContactID = c.Int(nullable: false, identity: true),
                        UserName = c.String(maxLength: 70),
                        UserMail = c.String(maxLength: 50),
                        Subject = c.String(maxLength: 50),
                        Message = c.String(),
                    })
                .PrimaryKey(t => t.ContactID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Contact2");
        }
    }
}
