using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriviaGame.Contract;
using TriviaGame.DAL;
using TriviaGame.DAL.EntityFramework;
using TriviaGame.Domain;
using TriviaGame.Error.General;
using TriviaGame.IO;

namespace TriviaGame.Controller
{
    public class TriviaController : ITriviaController
    {
        private static readonly IMapper cMapper;

        static TriviaController()
        {
            var mConfiguration = new MapperConfiguration(pConfiguration =>
            {
                pConfiguration.ShouldMapProperty = p => p.GetMethod.IsPublic || p.GetMethod.IsAssembly;
                pConfiguration.CreateMap<Question, QuestionDTO>();
                pConfiguration.CreateMap<Answer, AnswerDTO>();
                pConfiguration.CreateMap<Category, CategoryDTO>();
                pConfiguration.CreateMap<Difficulty, DiffucultyDTO>();

                pConfiguration.CreateMap<QuestionsSetDTO, QuestionsSet>();
                pConfiguration.CreateMap<UserDTO, User>();
            });

            cMapper = mConfiguration.CreateMapper();
        }
        TriviaDTO ITriviaController.CreateTrivia(UserDTO pUser, QuestionsSetDTO pQuestionSet, CategoryDTO pCategory, DiffucultyDTO diffuculty, int quantity)
        {
            using (var bDbContext = new TriviaDbContext())
            {
                using (IUnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    IList<Question> bList = bUoW.QuestionRepository.GetRandomQuestions(
                            pQuestionSet.Id,
                            pCategory.Id,
                            diffuculty.Id,
                            quantity
                        );

                    if (bList.Count == 0)
                        throw new NoResultsException();

                    IList<QuestionDTO> bQuestions = cMapper.Map<IList<QuestionDTO>>(bList);

                    bUoW.Complete();

                    return new TriviaDTO(pQuestionSet) { 
                        User = pUser,
                        Questions = bQuestions,
                        Diffuculty = diffuculty
                    };
                }
            }
        }

        void ITriviaController.SaveTrivia(TriviaDTO pTrivia)
        {
            using (var bDbContext = new TriviaDbContext())
            {
                using (IUnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    Session bSession = new Session(
                            cMapper.Map<User>(pTrivia.User),
                            pTrivia.GetFinalScore(),
                            pTrivia.GetSecondsSpent()
                        );

                    bUoW.SessionRepository.Add(bSession);

                    bUoW.Complete();
                }
            }
        }
    }
}
