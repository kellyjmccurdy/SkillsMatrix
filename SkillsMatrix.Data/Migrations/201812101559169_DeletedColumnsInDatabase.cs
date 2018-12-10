namespace SkillsMatrix.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeletedColumnsInDatabase : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Profile", "SkillId");
            DropColumn("dbo.Profile", "SkillLevel");
            DropColumn("dbo.Profile", "CertificationId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Profile", "CertificationId", c => c.Int(nullable: false));
            AddColumn("dbo.Profile", "SkillLevel", c => c.String());
            AddColumn("dbo.Profile", "SkillId", c => c.Int(nullable: false));
        }
    }
}
