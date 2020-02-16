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
            SeedUsers(pContext);

            SeedOpentdb(pContext);

            base.Seed(pContext);
        }

        private void SeedUsers(TriviaDbContext pContext)
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

        private void SeedOpentdb(TriviaDbContext pContext)
        {
            QuestionsSet bOpentdbSet = new QuestionsSet()
            {
                Id = 1,
                Name = "Open Trivia DB"
            };

            if (pContext.Set<QuestionsSet>().Find(bOpentdbSet.Id) == null)
                pContext.Set<QuestionsSet>().Add(bOpentdbSet);

            IList<Category> bOpentdbCategories = new List<Category>()
            {
                new Category()
                    {
                        Id = 1,
                        Name = "General Knowledge",
                        Set = bOpentdbSet
                    },
                    new Category()
                    {
                        Id = 2,
                        Name = "Entertainment: Books",
                        Set = bOpentdbSet
                    }
            };

            foreach (Category bCategory in bOpentdbCategories)
            {
                if (pContext.Set<Category>().Find(bCategory.Id) == null)
                    pContext.Set<Category>().Add(bCategory);
            }

            IList<Difficulty> bOpentdbDifficulties = new List<Difficulty>()
            {
                new Difficulty()
                {
                    Id = 1,
                    Description = "Easy",
                    Weight = 1,
                    Set = bOpentdbSet
                },
                new Difficulty()
                {
                    Id = 2,
                    Description = "Medium",
                    Weight = 2,
                    Set = bOpentdbSet
                },
                new Difficulty()
                {
                    Id = 3,
                    Description = "Hard",
                    Weight = 3,
                    Set = bOpentdbSet
                }
            };

            foreach (Difficulty bDifficulty in bOpentdbDifficulties)
            {
                if (pContext.Set<Difficulty>().Find(bDifficulty.Id) == null)
                    pContext.Set<Difficulty>().Add(bDifficulty);
            }

            IList<Question> bOpentdbQuestions = new List<Question>()
            {
                new Question()
                {
                    Id = 1,
                    Description = "What was the destination of the missing flight MH370?",
                    Category = bOpentdbCategories[0],
                    Difficulty = bOpentdbDifficulties[1],
                    Set = bOpentdbSet,
                    Answers = new List<Answer>()
                    {
                        new Answer()
                        {
                            Description = "Beijing",
                            IsCorrect = true
                        },
                        new Answer()
                        {
                            Description = "Kuala Lumpur",
                            IsCorrect = false
                        },
                        new Answer()
                        {
                            Description = "Singapore",
                            IsCorrect = false
                        },
                        new Answer()
                        {
                            Description = "Tokyo",
                            IsCorrect = false
                        }
                    }
                },
                new Question()
                {
                    Id = 2,
                    Description = "Which of the following card games revolves around numbers and basic math?",
                    Category = bOpentdbCategories[0],
                    Difficulty = bOpentdbDifficulties[0],
                    Set = bOpentdbSet,
                    Answers = new List<Answer>()
                    {
                        new Answer()
                        {
                            Description = "Uno",
                            IsCorrect = true
                        },
                        new Answer()
                        {
                            Description = "Go Fish",
                            IsCorrect = false
                        },
                        new Answer()
                        {
                            Description = "Twister",
                            IsCorrect = false
                        },
                        new Answer()
                        {
                            Description = "Munchkin",
                            IsCorrect = false
                        }
                    }
                },
                new Question()
                {
                    Id = 3,
                    Description = "Who wrote the 1967 horror novel 'Rosemary´s Baby'?",
                    Category = bOpentdbCategories[1],
                    Difficulty = bOpentdbDifficulties[0],
                    Set = bOpentdbSet,
                    Answers = new List<Answer>()
                    {
                        new Answer()
                        {
                            Description = "Ira Levin",
                            IsCorrect = true
                        },
                        new Answer()
                        {
                            Description = "Stephen King",
                            IsCorrect = false
                        },
                        new Answer()
                        {
                            Description = "Robert Bloch",
                            IsCorrect = false
                        },
                        new Answer()
                        {
                            Description = "Mary Shelley",
                            IsCorrect = false
                        }
                    }
                },
                new Question()
                {
                    Id = 4,
                    Description = "What's the second book in George R. R. Martin's 'A Song of Ice and Fire' series?",
                    Category = bOpentdbCategories[1],
                    Difficulty = bOpentdbDifficulties[1],
                    Set = bOpentdbSet,
                    Answers = new List<Answer>()
                    {
                        new Answer()
                        {
                            Description = "A Clash of Kings",
                            IsCorrect = true
                        },
                        new Answer()
                        {
                            Description = "A Dance with Dragons",
                            IsCorrect = false
                        },
                        new Answer()
                        {
                            Description = "A Storm of Swords",
                            IsCorrect = false
                        },
                        new Answer()
                        {
                            Description = "A Feast for Crows",
                            IsCorrect = false
                        }
                    }
                }
            };

            foreach (Question bQuestion in bOpentdbQuestions)
            {
                if (pContext.Set<Question>().Find(bQuestion.Id) == null)
                    pContext.Set<Question>().Add(bQuestion);
            }
        }
    }
}
