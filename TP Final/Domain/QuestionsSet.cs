using System;
using System.Collections.Generic;

namespace TriviaGame.Domain
{
    /// <summary>
    /// Un conjunto de preguntas
    /// </summary>
    public class QuestionsSet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MaxQuantity { get; set; }
        public string Adapter { get; set; }
        public virtual IList<Category> Categories { get; set; }
        public virtual IList<Difficulty> Difficulties { get; set; }
        public virtual IList<Question> Questions { get; set; }
    }
}