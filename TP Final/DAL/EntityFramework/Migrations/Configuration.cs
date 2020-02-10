using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Final.Domain;

namespace TP_Final.DAL.EntityFramework.Migrations
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
            IList<User> bDefaultUsers = new List<User>();

            bDefaultUsers.Add(new User()
            {
                Id = 1,
                FirstName = "Martín",
                LastName = "Lejman",
                FileNumber = "14119550",
                Password = "12345678",
                IsAdmin = true                
            });

            foreach(User bUser in bDefaultUsers)
            {
                if (pContext.Set<User>().Find(bUser.Id) == null)
                    pContext.Set<User>().Add(bUser);
            }

            base.Seed(pContext);
        }
    }
}
