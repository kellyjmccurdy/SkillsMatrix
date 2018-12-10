namespace SkillsMatrix.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenamedProfileServicesClass : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Profile", "QualificationId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Profile", "QualificationId");
        }
    }
}
