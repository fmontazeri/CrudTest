namespace FmCrudTest.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customer", "Email", c => c.String(maxLength: 50));
            CreateIndex("dbo.Customer", new[] { "FirstName", "LastName", "DateOfBirth" }, unique: true);
            CreateIndex("dbo.Customer", "Email", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Customer", new[] { "Email" });
            DropIndex("dbo.Customer", new[] { "FirstName", "LastName", "DateOfBirth" });
            AlterColumn("dbo.Customer", "Email", c => c.String());
        }
    }
}
