namespace Hastanee.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Doktorlar", "HemsireID", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Doktorlar", "HemsireID");
        }
    }
}
