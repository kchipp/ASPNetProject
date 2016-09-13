namespace ASPNetProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Address : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        AddressId = c.Int(nullable: false, identity: true),
                        Billing = c.Boolean(nullable: false),
                        Address1 = c.String(nullable: false, maxLength: 200),
                        Address2 = c.String(),
                        ZipCode = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AddressId)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Addresses", "UserId", "dbo.Users");
            DropIndex("dbo.Addresses", new[] { "UserId" });
            DropTable("dbo.Addresses");
        }
    }
}
