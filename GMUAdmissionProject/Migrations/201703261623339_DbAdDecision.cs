namespace GMUAdmissionProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DbAdDecision : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Applicants", "AdDecision", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Applicants", "AdDecision");
        }
    }
}
