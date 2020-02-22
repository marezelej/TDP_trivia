using System;
using System.Collections.Generic;

namespace TriviaGame.Domain
{
    /// <summary>
    /// Una sesión de preguntas
    /// </summary>
    public class Session
    {
        public int Id { get; set; }
        public int Score { get; set; }
        public int Quantity { get; set; }
        public TimeSpan Time { get; set; }
        public virtual User User { get; set; }
        public virtual QuestionsSet Set { get; set; }
        public virtual Category Category { get; set; }
        public virtual Difficulty Difficulty { get; set; }
        public virtual IList<SessionQuestion> Questions { get; set; }
    }
}