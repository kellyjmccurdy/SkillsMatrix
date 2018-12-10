namespace SkillsMatrix.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorrectingDatabase : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Qualification", "CertExpirationDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Qualification", "CertExpirationDate", c => c.DateTime());
        }
    }
}
