using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpentDB.IO
{
    public interface IQuestion
    {
        string Question { get; }

        QuestionCategory Category { get; }

        QuestionDifficulty Difficulty { get; }

        string CorrectAnswer { get; }

        IList<string> IncorrectAnswers { get; }
    }
}
