using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpentDB.IO
{
    public class QuestionDTO
    {
        [JsonProperty("question")]
        public string Question { get; internal set; }

        [JsonProperty("category")]
        public string Category { get; internal set; }

        [JsonProperty("type")]
        public string Type { get; internal set; }

        [JsonProperty("difficulty")]
        public string Difficulty { get; internal set; }

        [JsonProperty("correct_answer")]
        public string CorrectAnswer { get; internal set; }

        [JsonProperty("incorrect_answers")]
        public IList<string> IncorrectAnswers { get; internal set; }
    }
}
