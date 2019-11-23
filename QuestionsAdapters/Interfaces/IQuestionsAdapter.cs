using System;
using System.Collections.Generic;

namespace QuestionsAdapters
{
    public interface IQuestionsAdapter
    {
        IList<Question> GetQuestions();
    }
}
