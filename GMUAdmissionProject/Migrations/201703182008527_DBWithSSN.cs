namespace GMUAdmissionProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DBWithSSN : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Applicants", "SSN", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Applicants", "SSN");
        }
    }
}
