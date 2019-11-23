using System;
using System.Runtime.Serialization;

namespace opentdbAPI
{
    [Serializable]
    internal class APIException : Exception
    {
        private object error;

        public APIException()
        {
        }

        public APIException(object error)
        {
            this.error = error;
        }

        public APIException(string message) : base(message)
        {
        }

        public APIException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected APIException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}