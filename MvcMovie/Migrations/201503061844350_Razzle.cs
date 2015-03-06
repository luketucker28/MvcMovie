namespace MvcMovie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Razzle : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Razzle", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "Razzle");
        }
    }
}
