namespace FmCrudTest.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeColumnProperties : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Customer", new[] { "FirstName", "LastName", "DateOfBirth" });
            AlterColumn("dbo.Customer", "DateOfBirth", c => c.DateTime(nullable: false, storeType: "date"));
            AlterColumn("dbo.Customer", "PhoneNumber", c => c.String(maxLength: 11, unicode: false));
            CreateIndex("dbo.Customer", new[] { "FirstName", "LastName", "DateOfBirth" }, unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Customer", new[] { "FirstName", "LastName", "DateOfBirth" });
            AlterColumn("dbo.Customer", "PhoneNumber", c => c.String(maxLength: 8000, unicode: false));
            AlterColumn("dbo.Customer", "DateOfBirth", c => c.DateTime(nullable: false));
            CreateIndex("dbo.Customer", new[] { "FirstName", "LastName", "DateOfBirth" }, unique: true);
        }
    }
}
