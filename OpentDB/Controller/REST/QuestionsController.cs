using Newtonsoft.Json;
using OpentDB.Contract;
using OpentDB.Request;
using OpentDB.Response;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OpentDB.Controller
{
    public class QuestionsController : IQuestionsController
    {
        string iUrl = "https://opentdb.com/api.php";

        public GetQuestionsResponse GetQuestions(GetQuestionsRequest pRequest)
        {
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            // Se crea el request http
            HttpWebRequest mRequest = (HttpWebRequest)WebRequest.Create(iUrl);


            GetQuestionsResponse response = new GetQuestionsResponse();
            try
            {
                // Se ejecuta la consulta
                WebResponse mResponse = mRequest.GetResponse();

                // Se obtiene los datos de respuesta
                using (Stream responseStream = mResponse.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);

                    response = JsonConvert.DeserializeObject<GetQuestionsResponse>(reader.ReadToEnd());
                }
            }
            catch (WebException ex)
            {
                WebResponse mErrorResponse = ex.Response;
                using (Stream mResponseStream = mErrorResponse.GetResponseStream())
                {
                    StreamReader mReader = new StreamReader(mResponseStream, Encoding.GetEncoding("utf-8"));
                    string mErrorText = mReader.ReadToEnd();

                    response.Error = mErrorText;
                }
            }
            catch (Exception ex)
            {
                response.Error = ex.Message;
            }

            return response;
        }
    }
}
