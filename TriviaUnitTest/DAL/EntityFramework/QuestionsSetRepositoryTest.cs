using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriviaGame.DAL;
using TriviaGame.DAL.EntityFramework;
using TriviaGame.Domain;

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
                MaxQuantity = 20,
            };

            bSet.Categories = new List<Category>()
            {
                new Category()
                {
                    Id = 1,
                    Name = "Ciencia"
                }
            };

            bSet.Difficulties = new List<Difficulty>()
            {
                new Difficulty()
                {
                    Id = 1,
                    Description = "Easy"
                }
            };


            DbConnection connection = Effort.DbConnectionFactory.CreateTransient();
            using (var bDbContext = new TriviaDbContext(connection))
            {
                bDbContext.Database.CreateIfNotExists();

                using (IUnitOfWork bUoW = new UnitOfWork(bDbContext))
                {

                    bUoW.QuestionsSetRepository.Add(bSet);

                    bUoW.Complete();
                }
            }

            using (var bDbContext = new TriviaDbContext(connection))
            {
                using (IUnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    QuestionsSet bDBSet = bUoW.QuestionsSetRepository.Get(1);

                    Assert.AreEqual(bSet.Id, bDBSet.Id);
                    Assert.IsNotNull(bDBSet.Categories);
                    Assert.IsNotNull(bDBSet.Difficulties);

                    bUoW.Complete();
                }
            }
        }

        [TestMethod]
        public void GetAllTest()
        {
            QuestionsSet bSet = new QuestionsSet()
            {
                Id = 1,
                Name = "Test Questions Set",
                MaxQuantity = 20,
            };

            bSet.Categories = new List<Category>()
            {
                new Category()
                {
                    Id = 1,
                    Name = "Ciencia"
                }
            };

            bSet.Difficulties = new List<Difficulty>()
            {
                new Difficulty()
                {
                    Id = 1,
                    Description = "Easy"
                }
            };


            DbConnection connection = Effort.DbConnectionFactory.CreateTransient();
            using (var bDbContext = new TriviaDbContext(connection))
            {
                bDbContext.Database.CreateIfNotExists();

                using (IUnitOfWork bUoW = new UnitOfWork(bDbContext))
                {

                    bUoW.QuestionsSetRepository.Add(bSet);

                    bUoW.Complete();
                }
            }

            using (var bDbContext = new TriviaDbContext(connection))
            {
                using (IUnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    QuestionsSet bDBSet = bUoW.QuestionsSetRepository.GetAll().FirstOrDefault();

                    Assert.IsNotNull(bSet);
                    Assert.AreEqual(bSet.Id, bDBSet.Id);
                    Assert.IsNotNull(bDBSet.Categories);
                    Assert.IsNotNull(bDBSet.Difficulties);

                    bUoW.Complete();
                }
            }
        }
    }
}
