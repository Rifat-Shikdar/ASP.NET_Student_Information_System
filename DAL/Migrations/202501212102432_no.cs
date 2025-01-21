namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class no : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Schedules", "ClassTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Schedules", "ClassTime", c => c.DateTime());
        }
    }
}
