namespace HastaneRandevuEFCF_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class b2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Doktorlar", "AktifMi", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Doktorlar", "AktifMi");
        }
    }
}
