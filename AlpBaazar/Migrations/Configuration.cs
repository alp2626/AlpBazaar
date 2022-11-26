namespace AlpBaazar.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AlpBaazar.Models.AlpBazaarModel>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed= true;
        }

        protected override void Seed(AlpBaazar.Models.AlpBazaarModel context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            context.ManagersTypes.AddOrUpdate(m => m.ID, new Models.ManagerType() { ID = 1, Name = "Admin" });
            context.ManagersTypes.AddOrUpdate(m => m.ID, new Models.ManagerType() { ID = 2, Name = "Moderatör" });

        }
    }
}
