namespace GMUAdmissionProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DbWithSubMisDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Applicants", "SubDate", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Applicants", "SubDate");
        }
    }
}
