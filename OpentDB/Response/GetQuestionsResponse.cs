using Newtonsoft.Json;
using OpentDB.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpentDB.Response
{
    public class GetQuestionsResponse
    {
        [JsonProperty("response_code")]
        internal int ResponseCode { get; set; }

        [JsonProperty("results")]
        internal IEnumerable<QuestionDTO> Questions { get; set; }

        internal string Error { get; set; }

        internal bool HasError()
        {
            return Error != null;
        }
    }
}
