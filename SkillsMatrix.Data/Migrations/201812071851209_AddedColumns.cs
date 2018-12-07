namespace SkillsMatrix.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedColumns : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Qualification", "OwnerId", c => c.Int(nullable: false));
            AddColumn("dbo.Qualification", "EmployeeId", c => c.Int(nullable: false));
            AlterColumn("dbo.Qualification", "CertExpirationDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Qualification", "CertExpirationDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Qualification", "EmployeeId");
            DropColumn("dbo.Qualification", "OwnerId");
        }
    }
}
