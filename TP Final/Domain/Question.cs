using System.Collections.Generic;

namespace TP_Final.Domain
{
    /// <summary>
    /// Una pregunta
    /// </summary>
    internal class Question
    {
        internal int Id { get; set; }
        internal string Description { get; set; }
        internal QuestionsSet Set { get; set; }
        internal Category Category { get; set; }
        internal Difficulty Difficulty { get; set; }
        internal IList<Answer> Answers { get; set; }
    }
}