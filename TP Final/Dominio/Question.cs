using System.Collections.Generic;

namespace TP_Final.Dominio
{
    internal class Question
    {
        int Id { get; set; }
        string Description { get; set; }
        IList<Answer> Answers { get; set; }
        Answer CorrectAnswer { get; set; }
    }
}