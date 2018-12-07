namespace SkillsMatrix.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorrectedItems : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Qualification", "NameOfSkill", c => c.Int(nullable: false));
            DropColumn("dbo.Qualification", "Skill");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Qualification", "Skill", c => c.Int(nullable: false));
            DropColumn("dbo.Qualification", "NameOfSkill");
        }
    }
}
