using System.Collections.Generic;

namespace TP_Final.Domain
{
    /// <summary>
    /// Una pregunta
    /// </summary>
    internal class Question
    {
        int Id { get; set; }
        string Description { get; set; }
        Category Category { get; set; }
        Difficulty Difficulty { get; set; }
        IList<Answer> Answers { get; set; }
        IList<Answer> CorrectAnswers { get; set; }
    }
}