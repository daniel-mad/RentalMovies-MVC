namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNumberAvailableToMaviesTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "NumnerAvailable", c => c.Short(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "NumnerAvailable");
        }
    }
}
