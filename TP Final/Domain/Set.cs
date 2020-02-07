using System.Collections.Generic;

namespace TP_Final.Domain
{
    /// <summary>
    /// Un conjunto de preguntas
    /// </summary>
    internal class Set
    {
        int Id { get; set; }
        string Name { get; set; }
        IList<Category> Categories { get; set; }
        IList<Difficulty> Difficulties { get; set; }
        IList<Question> Questions { get; set; }
    }
}