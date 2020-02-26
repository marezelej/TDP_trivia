using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriviaGame.Domain;

namespace TriviaGame.DAL.EntityFramework.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<TriviaDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "TP_Final.DAL.EntityFramework.TriviaDBContext";
        }

        protected override void Seed(TriviaDbContext pContext)
        {
            UserSeeder.Seed(pContext);

            QuestionsSetSeeder.Seed(pContext);

            base.Seed(pContext);
        }
    }
}
