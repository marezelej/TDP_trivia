using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriviaGame.IO;

namespace TriviaGame.Contract
{
    public interface IQuestionsSetController
    {
        IEnumerable<QuestionsSetDTO> GetAll();
    }
}
