namespace MultipleDbContext001.Migrations.Configuration2
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Config2 : DbMigrationsConfiguration<MultipleDbContext001.DalDbRemote.RemoteApplicationDbContext>
    {
        public Config2()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\Configuration2";
        }

        protected override void Seed(MultipleDbContext001.DalDbRemote.RemoteApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
