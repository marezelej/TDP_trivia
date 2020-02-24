using Newtonsoft.Json;
using OpentDB.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpentDB.Response.REST
{
    public class GetQuestionsResponse : IGetQuestionsResponse
    {
        [JsonProperty("response_code")]
        public int ResponseCode { get; set; }

        [JsonProperty("results")]
        internal IList<QuestionDTO> Results {private get; set;}

        public IEnumerable<IQuestion> Questions => Results.OfType<IQuestion>();

        public string Error { get; set; }

        public bool HasError()
        {
            return Error != null;
        }
    }
}
