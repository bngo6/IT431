namespace GMUAdmissionProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DbWithEnrollMentYear : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Applicants", "EnrollYear", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Applicants", "EnrollYear");
        }
    }
}
