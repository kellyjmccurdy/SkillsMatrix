namespace SkillsMatrix.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedStuff : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employee", "CreatedUtc", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.Employee", "ModifiedUtc", c => c.DateTimeOffset(precision: 7));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employee", "ModifiedUtc");
            DropColumn("dbo.Employee", "CreatedUtc");
        }
    }
}
