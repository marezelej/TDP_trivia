using Newtonsoft.Json;
using OpentDB.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpentDB.Response.REST
{
    class QuestionCategoryConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(string);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            IDictionary<string, QuestionCategory> bMap = new Dictionary<string, QuestionCategory>();
            bMap.Add("General Knowledge", QuestionCategory.GeneralKnowledge);
            bMap.Add("Entertainment: Books", QuestionCategory.Books);
            bMap.Add("Entertainment: Film", QuestionCategory.Film);
            bMap.Add("Entertainment: Music", QuestionCategory.Music);
            bMap.Add("Entertainment: Musicals &amp; Theatres", QuestionCategory.MusicalsAndTheatres);
            bMap.Add("Entertainment: Television", QuestionCategory.Television);
            bMap.Add("Entertainment: Video Games", QuestionCategory.VideoGames);
            bMap.Add("Entertainment: Board Games", QuestionCategory.BoardGames);
            bMap.Add("Science &amp; Nature", QuestionCategory.ScienceAndNature);
            bMap.Add("Science: Computers", QuestionCategory.Computers);
            bMap.Add("Science: Mathematics", QuestionCategory.Mathematics);
            bMap.Add("Mythology", QuestionCategory.Mythology);
            bMap.Add("Sports", QuestionCategory.Sports);
            bMap.Add("Geography", QuestionCategory.Geography);
            bMap.Add("History", QuestionCategory.History);
            bMap.Add("Politics", QuestionCategory.Politics);
            bMap.Add("Art", QuestionCategory.Art);
            bMap.Add("Celebrities", QuestionCategory.Celebrities);
            bMap.Add("Animals", QuestionCategory.Animals);
            bMap.Add("Vehicles", QuestionCategory.Vehicles);
            bMap.Add("Entertainment: Comics", QuestionCategory.Comics);
            bMap.Add("Science: Gadgets", QuestionCategory.Gadgets);
            bMap.Add("Entertainment: Japanese Anime &amp; Manga", QuestionCategory.AnimeAndManga);
            bMap.Add("Entertainment: Cartoon &amp; Animations", QuestionCategory.CartoonAndAnimations);

            var enumString = (string)reader.Value;

            return bMap[enumString];
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
