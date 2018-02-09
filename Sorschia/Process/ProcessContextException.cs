using System;
using System.Runtime.Serialization;

namespace Sorschia.Process
{
    public class ProcessContextException : Exception
    {
        public ProcessContextException()
        {
        }

        public ProcessContextException(string message) : base(message)
        {
        }

        public ProcessContextException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ProcessContextException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
