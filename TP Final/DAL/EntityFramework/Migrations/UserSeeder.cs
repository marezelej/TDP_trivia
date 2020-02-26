using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriviaGame.Domain;

namespace TriviaGame.DAL.EntityFramework.Migrations
{
    class UserSeeder
    {
        public static void Seed(DbContext pContext)
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

            foreach (User bUser in bDefaultUsers)
            {
                if (pContext.Set<User>().Find(bUser.Id) == null)
                    pContext.Set<User>().Add(bUser);
            }
        }
    }
}
