using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace TriviaGame.IO
{
    public class TriviaDTO
    {
        public UserDTO User { get; internal set; }
        public QuestionsSetDTO QuestionsSet { get; internal set; }
        public DiffucultyDTO Diffuculty { get; internal set; }
        public IList<QuestionDTO> Questions { get; internal set; }
        public int TimeLimit { get; internal set; }
        public DateTime StartedAt { get; private set; }
        public DateTime? FinishedAt { get; private set; }
        public TriviaDTO(QuestionsSetDTO pQuestionSet)
        {
            QuestionsSet = pQuestionSet;
            TimeLimit = 10;
        }
        public void Start()
        {
            StartedAt = DateTime.Now;
        }
        public void Finish()
        {
            FinishedAt = DateTime.Now;
        }
        public int GetSecondsSpent()
        {
            DateTime from = DateTime.Now;
            if (FinishedAt != null)
                from = (DateTime) FinishedAt;
            return (int) from.Subtract(StartedAt).TotalSeconds;
        }
        public int GetRemainingSeconds()
        {
            if (TimeLimit > GetSecondsSpent())
                return TimeLimit - GetSecondsSpent();
            return 0;
        }
        public float GetFinalScore()
        {
            return QuestionsSet.GetAdapter().GetScore(
                    Questions,
                    Diffuculty,
                    GetSecondsSpent()
                );
        }
        public int GetCorrectQuantity()
        {
            return Questions.Sum(q => 
                    Convert.ToInt16(q.SelectedAnswer != null && q.SelectedAnswer.IsCorrect)
                );
        }
    }
}
