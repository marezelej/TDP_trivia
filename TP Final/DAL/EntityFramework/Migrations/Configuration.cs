using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Final.DAL.EntityFramework.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<TriviaDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "TP_Final.DAL.EntityFramework.TriviaDBContext";
        }

        protected override void Seed(TriviaDbContext pContext)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
