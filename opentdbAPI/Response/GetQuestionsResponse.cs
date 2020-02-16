using Newtonsoft.Json;
using opentdbAPI.IO;
using System;
using System.Collections.Generic;
using System.Text;

namespace opentdbAPI.Response
{
    internal class GetQuestionsResponse
    {
        [JsonProperty("response_code")]
        internal int ResponseCode { get; set; }

        [JsonProperty("results")]
        internal IEnumerable<QuestionDTO> Questions { get; set; }
    }
}
