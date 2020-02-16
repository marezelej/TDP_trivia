using OpentDB.Request;
using OpentDB.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpentDB.Controller
{
    interface IQuestionsController
    {
        GetQuestionsResponse GetQuestions(GetQuestionsRequest pRequest);
    }
}
