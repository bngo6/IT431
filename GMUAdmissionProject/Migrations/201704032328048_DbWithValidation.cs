namespace GMUAdmissionProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DbWithValidation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Applicants", "FirstName", c => c.String(nullable: false, maxLength: 60));
            AlterColumn("dbo.Applicants", "MiddleName", c => c.String(nullable: false, maxLength: 60));
            AlterColumn("dbo.Applicants", "LastName", c => c.String(nullable: false, maxLength: 60));
            AlterColumn("dbo.Applicants", "SSN", c => c.String(nullable: false));
            AlterColumn("dbo.Applicants", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Applicants", "Phone", c => c.String(nullable: false));
            AlterColumn("dbo.Applicants", "Street", c => c.String(nullable: false, maxLength: 60));
            AlterColumn("dbo.Applicants", "City", c => c.String(nullable: false, maxLength: 60));
            AlterColumn("dbo.Applicants", "State", c => c.String(nullable: false, maxLength: 60));
            AlterColumn("dbo.Applicants", "Zipcode", c => c.String(nullable: false));
            AlterColumn("dbo.Applicants", "DOB", c => c.String(nullable: false));
            AlterColumn("dbo.Applicants", "Gender", c => c.String(nullable: false));
            AlterColumn("dbo.Applicants", "HSName", c => c.String(nullable: false, maxLength: 60));
            AlterColumn("dbo.Applicants", "HSCity", c => c.String(nullable: false, maxLength: 60));
            AlterColumn("dbo.Applicants", "GradDate", c => c.String(nullable: false));
            AlterColumn("dbo.Applicants", "AreaOfInterest", c => c.String(nullable: false));
            AlterColumn("dbo.Applicants", "StuType", c => c.String(nullable: false));
            AlterColumn("dbo.Applicants", "EnrollDate", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Applicants", "EnrollDate", c => c.String());
            AlterColumn("dbo.Applicants", "StuType", c => c.String());
            AlterColumn("dbo.Applicants", "AreaOfInterest", c => c.String());
            AlterColumn("dbo.Applicants", "GradDate", c => c.String());
            AlterColumn("dbo.Applicants", "HSCity", c => c.String());
            AlterColumn("dbo.Applicants", "HSName", c => c.String());
            AlterColumn("dbo.Applicants", "Gender", c => c.String());
            AlterColumn("dbo.Applicants", "DOB", c => c.String());
            AlterColumn("dbo.Applicants", "Zipcode", c => c.String());
            AlterColumn("dbo.Applicants", "State", c => c.String());
            AlterColumn("dbo.Applicants", "City", c => c.String());
            AlterColumn("dbo.Applicants", "Street", c => c.String());
            AlterColumn("dbo.Applicants", "Phone", c => c.String());
            AlterColumn("dbo.Applicants", "Email", c => c.String());
            AlterColumn("dbo.Applicants", "SSN", c => c.String());
            AlterColumn("dbo.Applicants", "LastName", c => c.String());
            AlterColumn("dbo.Applicants", "MiddleName", c => c.String());
            AlterColumn("dbo.Applicants", "FirstName", c => c.String());
        }
    }
}
