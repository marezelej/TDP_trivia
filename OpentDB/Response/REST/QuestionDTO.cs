using Newtonsoft.Json;
using OpentDB.IO;
using System;
using System.Collections.Generic;

namespace OpentDB.Response.REST
{
    public class QuestionDTO: IQuestion
    {
        [JsonProperty("question")]
        public string Question { get; internal set; }

        [JsonProperty("category")]
        [JsonConverter(typeof(QuestionCategoryConverter))]
        public QuestionCategory Category { get; internal set; }

        [JsonProperty("type")]
        public string Type { get; internal set; }

        [JsonProperty("difficulty")]
        public QuestionDifficulty Difficulty { get; internal set; }

        [JsonProperty("correct_answer")]
        public string CorrectAnswer { get; internal set; }

        [JsonProperty("incorrect_answers")]
        public IList<string> IncorrectAnswers { get; internal set; }
    }
}
