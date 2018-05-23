namespace outpostwarsAPINET.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProfileType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "ProfileType", c => c.String());
            AddColumn("dbo.AspNetUsers", "ProfileID", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "ProfileID");
            DropColumn("dbo.AspNetUsers", "ProfileType");
        }
    }
}
