using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriviaGame.Domain;
using System.Data.Entity;

namespace TriviaGame.DAL.EntityFramework
{
    class QuestionsSetRepository : Repository<QuestionsSet, TriviaDbContext>, IQuestionsSetRepository
    {
        /// <summary>
        /// Construye el repositorio utilizando el DbContext dado
        /// </summary>
        public QuestionsSetRepository(TriviaDbContext pDbContext) : base(pDbContext)
        {

        }

        public IEnumerable<QuestionsSet> GetAllWithCategoryAndDifficulty()
        {
            return iDbContext.QuestionSets
                .Include(pSet => pSet.Categories)
                .Include(pSet => pSet.Difficulties)
                .ToArray();
        }
    }
}
