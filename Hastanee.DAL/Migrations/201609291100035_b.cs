namespace Hastanee.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class b : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Hemsireler", "AtandiMi", c => c.Boolean());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Hemsireler", "AtandiMi", c => c.Boolean(nullable: false));
        }
    }
}
