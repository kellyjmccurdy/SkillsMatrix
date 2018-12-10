namespace SkillsMatrix.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Corrections : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Profile", "EmployeeId");
            CreateIndex("dbo.Profile", "QualificationId");
            AddForeignKey("dbo.Profile", "EmployeeId", "dbo.Employee", "EmployeeId", cascadeDelete: true);
            AddForeignKey("dbo.Profile", "QualificationId", "dbo.Qualification", "QualificationId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Profile", "QualificationId", "dbo.Qualification");
            DropForeignKey("dbo.Profile", "EmployeeId", "dbo.Employee");
            DropIndex("dbo.Profile", new[] { "QualificationId" });
            DropIndex("dbo.Profile", new[] { "EmployeeId" });
        }
    }
}
