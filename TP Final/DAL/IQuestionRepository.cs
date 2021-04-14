using System.Collections.Generic;
using TriviaGame.Domain;

namespace TriviaGame.DAL
{
    interface IQuestionRepository : IRepository<Question>
    {
        IList<Question> GetRandomQuestions(int SetId, int CategoryId, int DifficultyId, int quantity);
    }
}