using OpentDB.Controller.REST.Service.Error;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OpentDB.Controller.REST.Service.NET
{
    /// <summary>
    /// Un servicio web basado en la libreria System.NET
    /// </summary>
    internal class WebService : IWebService
    {
        public WebService()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        }

        /// <summary>
        /// Obtiene el contenido de una ruta determinada
        /// </summary>
        /// <param name="pUrl">La ruta a obtener</param>
        /// <returns>El contenido de la ruta</returns>
        public string Get(string pUrl)
        {
            try
            {
                using (WebClient bClient = new WebClient())
                {
                    using (StreamReader bReader = new StreamReader(bClient.OpenRead(pUrl)))
                    {
                        return bReader.ReadToEnd();
                    }
                }
            } catch(WebException e)
            {
                WebResponse mErrorResponse = e.Response;
                using (Stream mResponseStream = mErrorResponse.GetResponseStream())
                {
                    StreamReader mReader = new StreamReader(mResponseStream, Encoding.GetEncoding("utf-8"));
                    string mErrorText = mReader.ReadToEnd();

                    throw new CommunicationException(e, mErrorText);
                }
            }
        }
    }
}
