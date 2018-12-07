namespace SkillsMatrix.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedColumnToTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Qualification", "Skill", c => c.Int(nullable: false));
            AddColumn("dbo.Qualification", "CertExpirationDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Qualification", "CreatedUtc", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.Qualification", "ModifiedUtc", c => c.DateTimeOffset(precision: 7));
            DropColumn("dbo.Qualification", "SkillsId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Qualification", "SkillsId", c => c.Int(nullable: false));
            DropColumn("dbo.Qualification", "ModifiedUtc");
            DropColumn("dbo.Qualification", "CreatedUtc");
            DropColumn("dbo.Qualification", "CertExpirationDate");
            DropColumn("dbo.Qualification", "Skill");
        }
    }
}
