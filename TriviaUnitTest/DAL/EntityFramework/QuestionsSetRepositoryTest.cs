using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TP_Final.DAL.EntityFramework;
using TP_Final.Domain;

namespace TriviaUnitTest.DAL.EntityFramework
{
    [TestClass]
    public class QuestionsSetRepositoryTest
    {
        [TestMethod]
        public void TestAdd()
        {
            QuestionsSet bSet = new QuestionsSet()
            {
                Id = 1,
                Name = "Test Questions Set",
                MaxQuantity = 20
            };

            var connection = Effort.DbConnectionFactory.CreateTransient();
            using (var context = new TriviaDbContext(connection))
            {
                context.Database.CreateIfNotExists();

                QuestionsSetRepository bRepository = new QuestionsSetRepository(context);

                bRepository.Add(bSet);

                Assert.Equals(bSet, bRepository.Get(1));
            }
        }
    }
}
