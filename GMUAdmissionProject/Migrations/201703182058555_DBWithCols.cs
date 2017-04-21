namespace GMUAdmissionProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DBWithCols : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Applicants", "MiddleName", c => c.String());
            AddColumn("dbo.Applicants", "Email", c => c.String());
            AddColumn("dbo.Applicants", "Phone", c => c.String());
            AddColumn("dbo.Applicants", "Street", c => c.String());
            AddColumn("dbo.Applicants", "City", c => c.String());
            AddColumn("dbo.Applicants", "State", c => c.String());
            AddColumn("dbo.Applicants", "Zipcode", c => c.String());
            AddColumn("dbo.Applicants", "DOB", c => c.String());
            AddColumn("dbo.Applicants", "Gender", c => c.String());
            AddColumn("dbo.Applicants", "HSName", c => c.String());
            AddColumn("dbo.Applicants", "HSCity", c => c.String());
            AddColumn("dbo.Applicants", "GradDate", c => c.String());
            AddColumn("dbo.Applicants", "GPA", c => c.Double(nullable: false));
            AddColumn("dbo.Applicants", "MthScore", c => c.Double(nullable: false));
            AddColumn("dbo.Applicants", "VerbScore", c => c.Double(nullable: false));
            AddColumn("dbo.Applicants", "AreaOfInterest", c => c.String());
            AddColumn("dbo.Applicants", "StuType", c => c.String());
            AddColumn("dbo.Applicants", "EnrollDate", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Applicants", "EnrollDate");
            DropColumn("dbo.Applicants", "StuType");
            DropColumn("dbo.Applicants", "AreaOfInterest");
            DropColumn("dbo.Applicants", "VerbScore");
            DropColumn("dbo.Applicants", "MthScore");
            DropColumn("dbo.Applicants", "GPA");
            DropColumn("dbo.Applicants", "GradDate");
            DropColumn("dbo.Applicants", "HSCity");
            DropColumn("dbo.Applicants", "HSName");
            DropColumn("dbo.Applicants", "Gender");
            DropColumn("dbo.Applicants", "DOB");
            DropColumn("dbo.Applicants", "Zipcode");
            DropColumn("dbo.Applicants", "State");
            DropColumn("dbo.Applicants", "City");
            DropColumn("dbo.Applicants", "Street");
            DropColumn("dbo.Applicants", "Phone");
            DropColumn("dbo.Applicants", "Email");
            DropColumn("dbo.Applicants", "MiddleName");
        }
    }
}
