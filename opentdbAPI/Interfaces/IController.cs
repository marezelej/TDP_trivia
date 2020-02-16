using opentdbAPI.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace opentdbAPI
{
    internal interface IController
    {
        GetQuestionsResponse GetQuestions(GetQuestionRequest pRequest);
    }
}
