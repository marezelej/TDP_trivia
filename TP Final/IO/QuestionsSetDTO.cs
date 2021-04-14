using System;
using System.Collections.Generic;
using TriviaGame.Contract;

namespace TriviaGame.IO
{
    public class QuestionsSetDTO
    {
        public int Id { get; internal set; }
        public string Name { get; internal set; }
        public string Adapter { get; internal set; }
        public IEnumerable<CategoryDTO> Categories { get; internal set; }
        public IEnumerable<DiffucultyDTO> Difficulties { get; internal set; }
        public int MaxQuantity { get; internal set; }
        public IQuestionsAdapter GetAdapter()
        {
            Type type = Type.GetType(Adapter);
            return (IQuestionsAdapter) Activator.CreateInstance(type);
        }
    }
}