using System.Collections.Generic;

namespace TP_Final.Domain
{
    /// <summary>
    /// Un conjunto de preguntas
    /// </summary>
    internal class Set
    {
        internal int Id { get; set; }
        internal string Name { get; set; }
        internal IList<Category> Categories { get; set; }
        internal IList<Difficulty> Difficulties { get; set; }
        internal IList<Question> Questions { get; set; }
    }
}