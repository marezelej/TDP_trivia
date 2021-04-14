using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriviaGame.IO;

namespace TriviaGame.Contract
{
    public interface ITriviaController
    {
        TriviaDTO CreateTrivia(UserDTO pUser, QuestionsSetDTO pQuestionSet, CategoryDTO pCategory, DiffucultyDTO diffuculty, int quantity);
        void SaveTrivia(TriviaDTO trivia);
    }
}
