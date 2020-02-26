using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriviaGame.Domain;

namespace TriviaGame.DAL.EntityFramework.Migrations
{
    class QuestionsSetSeeder
    {
        public static void Seed(DbContext pContext)
        {
            QuestionsSet bOpentdbSet = new QuestionsSet()
            {
                Id = 1,
                Name = "Open Trivia DB",
                MaxQuantity = 20
            };

            bOpentdbSet.Categories = new List<Category>()
            {
                new Category()
                    {
                        Id = 1,
                        Name = "General Knowledge"
                    },
                    new Category()
                    {
                        Id = 2,
                        Name = "Entertainment: Books"
                    }
            };

            bOpentdbSet.Difficulties = new List<Difficulty>()
            {
                new Difficulty()
                {
                    Id = 1,
                    Description = "Easy",
                    Weight = 1
                },
                new Difficulty()
                {
                    Id = 2,
                    Description = "Medium",
                    Weight = 2
                },
                new Difficulty()
                {
                    Id = 3,
                    Description = "Hard",
                    Weight = 3
                }
            };

            bOpentdbSet.Questions = new List<Question>()
            {
                new Question()
                {
                    Id = 1,
                    Description = "What was the destination of the missing flight MH370?",
                    Category = bOpentdbSet.Categories[0],
                    Difficulty = bOpentdbSet.Difficulties[1],
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
                    Category = bOpentdbSet.Categories[0],
                    Difficulty = bOpentdbSet.Difficulties[0],
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
                    Category = bOpentdbSet.Categories[1],
                    Difficulty = bOpentdbSet.Difficulties[0],
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
                    Category = bOpentdbSet.Categories[1],
                    Difficulty = bOpentdbSet.Difficulties[1],
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

            if (pContext.Set<QuestionsSet>().Find(bOpentdbSet.Id) == null)
                pContext.Set<QuestionsSet>().Add(bOpentdbSet);
        }
    }
}
