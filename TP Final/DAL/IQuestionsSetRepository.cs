using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriviaGame.Domain;

namespace TriviaGame.DAL
{
    interface IQuestionsSetRepository : IRepository<QuestionsSet>
    {
        IEnumerable<QuestionsSet> GetAllWithCategoryAndDifficulty();
    }
}
