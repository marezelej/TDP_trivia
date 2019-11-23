using System;
using System.Collections.Generic;
using System.Text;

namespace opentdbAPI
{
    public interface IController
    {
        GetQuestionResponse GetQuestions(GetQuestionRequest pRequest);
    }
}
