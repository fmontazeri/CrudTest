using FmCrudTest.Data.Configuratins;
using FmCrudTest.Data.Context;

namespace FmCrudTest.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FmCrudTest.Data.Context.TestDbContext>
    {
        public Configuration()
        {
          
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FmCrudTest.Data.Context.TestDbContext context)
        {

        }
    }
}
