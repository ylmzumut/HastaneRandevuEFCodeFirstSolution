namespace HastaneRandevuEFCF_DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<HastaneRandevuEFCF_DAL.MyContext>
    {
        public Configuration()
        {
            //eğer burası false kalsın isterseniz add-migration ile migration eklemesi yapmanız gerekiyor.
            //eğer burayı true olarak değiştirirseniz add-migration'a gerek yok
            
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(HastaneRandevuEFCF_DAL.MyContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
