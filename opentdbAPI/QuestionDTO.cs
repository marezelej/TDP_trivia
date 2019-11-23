using System;
using System.Collections.Generic;

namespace opentdbAPI
{
    public class QuestionDTO
    {
        private string iQuestion;
        private string iCategory;
        private string iType;
        private string iDifficulty;
        private string iCorrectAnswer;
        private IList<string> iIncorrectAnswers = new List<string>();

        public string Question { get; internal set; }
        public string Category { get; internal set; }
        public string Type { get; internal set; }
        public string Difficulty { get; internal set; }
        public string CorrectAnswer { get; internal set; }
        public IList<string> IncorrectAnswers { get; }

        internal void AddIncorrectAnswer(string pIncorrectAnswer)
        {
            iIncorrectAnswers.Add(pIncorrectAnswer);
        }
    }
}