using System;
using System.Runtime.Serialization;

namespace Sorschia.Data
{
    public class ConnectionStringException : Exception
    {
        public ConnectionStringException()
        {
        }

        public ConnectionStringException(string message) : base(message)
        {
        }

        public ConnectionStringException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ConnectionStringException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
