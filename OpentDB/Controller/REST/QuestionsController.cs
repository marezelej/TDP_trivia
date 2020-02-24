using Newtonsoft.Json;
using OpentDB.Controller.REST.Service;
using OpentDB.Controller.REST.Service.Error;
using OpentDB.Controller.REST.Service.NET;
using OpentDB.IO;
using OpentDB.Request;
using OpentDB.Response;
using OpentDB.Response.REST;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace OpentDB.Controller
{
    internal class QuestionsController : IQuestionsController
    {
        IWebService iWebService = new WebService();
        string iUrl = "https://opentdb.com/api.php?";

        /// <summary>
        /// Constructor sin parametros
        /// </summary>
        internal QuestionsController()
        {

        }

        /// <summary>
        /// Constructor que permite definir el servicio que realizara las peticiones HTTP
        /// </summary>
        /// <param name="pService">El servicio a utilizar</param>
        internal QuestionsController(IWebService pService)
        {
            iWebService = pService;
        }

        /// <summary>
        /// Realiza una peticion HTTP al servidor de opentdb con la informacion de pRequest
        /// y devuelve la respuesta obtenida
        /// </summary>
        /// <param name="pRequest">La peticion a realizar</param>
        /// <returns>La respuesta obtenida</returns>
        public IGetQuestionsResponse GetQuestions(GetQuestionsRequest pRequest)
        {
            string bEndpoint = iUrl;

            bEndpoint += $"&amount={pRequest.Quantity}";

            if (pRequest.Category != IO.QuestionCategory.Any)
                bEndpoint += $"&category={pRequest.Category}";

            if (pRequest.Difficulty != IO.QuestionDifficulty.Any)
                bEndpoint += $"&category={pRequest.Difficulty.ToString()}";

            if(pRequest.Type != QuestionType.Any)
                bEndpoint += $"&type={pRequest.Type.ToString()}";



            GetQuestionsResponse bResponse = new GetQuestionsResponse();
            try
            {
                string bContent = iWebService.Get(bEndpoint);
                bResponse = JsonConvert.DeserializeObject<GetQuestionsResponse>(bContent);
                Decode(bResponse);
            }
            catch (CommunicationException e)
            {
                bResponse.Error = $"Error de comunicacion con el servidor: '{e.Message}'";
            }
            catch (Exception e)
            {
                bResponse.Error = $"Error inesperado: '{e.Message}'";
            }

            return bResponse;
        }

        private void Decode(GetQuestionsResponse pResponse)
        {
            if (pResponse.ResponseCode != 0)
                return;

            foreach(QuestionDTO bQUestion in pResponse.Questions)
            {
                bQUestion.Question = HttpUtility.HtmlDecode(bQUestion.Question);
                bQUestion.CorrectAnswer = HttpUtility.HtmlDecode(bQUestion.CorrectAnswer);
                bQUestion.IncorrectAnswers.Cast<string>().ToList().ConvertAll(b => HttpUtility.HtmlDecode(b));
            }
        }
    }
}
