namespace MultipleDbContext001.Migrations.Configuration1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Config1 : DbMigrationsConfiguration<MultipleDbContext001.DalDbLocal.LocalApplicationDbContext>
    {
        public Config1()
        {
            AutomaticMigrationsEnabled = true;
            MigrationsDirectory = @"Migrations\Configuration1";
        }

        protected override void Seed(MultipleDbContext001.DalDbLocal.LocalApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
