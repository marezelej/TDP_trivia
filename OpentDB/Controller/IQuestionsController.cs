using OpentDB.Request;
using OpentDB.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpentDB.Controller
{
    /// <summary>
    /// Un controlador de preguntas
    /// </summary>
    internal interface IQuestionsController
    {
        /// <summary>
        /// Devuelve las preguntas para una peticion dada
        /// </summary>
        /// <param name="pRequest">La peticion</param>
        /// <returns>Las preguntas obtenidas</returns>
        IGetQuestionsResponse GetQuestions(GetQuestionsRequest pRequest);
    }
}
