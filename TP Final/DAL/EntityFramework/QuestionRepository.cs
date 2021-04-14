using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriviaGame.Domain;

namespace TriviaGame.DAL.EntityFramework
{
    class QuestionRepository: Repository<Question, TriviaDbContext>, IQuestionRepository
    {
        /// <summary>
        /// Construye el repositorio utilizando el DbContext dado
        /// </summary>
        public QuestionRepository(TriviaDbContext pDbContext) : base(pDbContext)
        {

        }

        public IList<Question> GetRandomQuestions(int SetId, int CategoryId, int DifficultyId, int quantity)
        {
            return iDbContext.Questions
                .Where(q => q.Set.Id == SetId)
                .Where(q => q.Category.Id == CategoryId)
                .Where(q => q.Difficulty.Id == DifficultyId)
                .OrderBy(q => Guid.NewGuid())
                .Take(quantity)
                .ToList();
        }
    }
}
