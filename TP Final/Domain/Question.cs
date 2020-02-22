using System.Collections.Generic;

namespace TriviaGame.Domain
{
    /// <summary>
    /// Una pregunta
    /// </summary>
    public class Question
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public virtual QuestionsSet Set { get; set; }
        public virtual Category Category { get; set; }
        public virtual Difficulty Difficulty { get; set; }
        public virtual IList<Answer> Answers { get; set; }
    }
}