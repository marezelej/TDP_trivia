using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OpentDB.Controller.REST.Service.Error
{
    /// <summary>
    /// Error que se produce cuando ocurre una excepcion al comunicarse con el servicio
    /// </summary>
    class CommunicationException : Exception
    {
        public Exception OriginalException { get; private set; }

        public CommunicationException(string bMessage): base(bMessage)
        {

        }

        public CommunicationException(Exception e): base(e.Message)
        {
            OriginalException = e;
        }

        public CommunicationException(Exception e, string mErrorText) : base(mErrorText)
        {
            OriginalException = e;
        }
    }
}
