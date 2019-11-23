using System;
using System.IO;
using System.Net;
using System.Text;
using System.Web;
using Newtonsoft.Json;

namespace opentdbAPI
{
    public class OpentbController : IController
    {
        string iUrl = "https://opentdb.com/api.php";
        public GetQuestionResponse GetQuestions(GetQuestionRequest pRequest)
        {
            GetQuestionResponse response = new GetQuestionResponse();

            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            // Se crea el request http
            HttpWebRequest mRequest = (HttpWebRequest)WebRequest.Create(iUrl);

            try
            {
                // Se ejecuta la consulta
                WebResponse mResponse = mRequest.GetResponse();

                // Se obtiene los datos de respuesta
                using (Stream responseStream = mResponse.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);

                    // Se parsea la respuesta y se serializa a JSON a un objeto dynamic
                    dynamic mResponseJSON = JsonConvert.DeserializeObject(reader.ReadToEnd());

                    response.SetResponse(mResponseJSON);
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
