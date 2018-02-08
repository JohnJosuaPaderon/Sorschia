using System;
using System.Runtime.Serialization;

namespace Sorschia.Data
{
    public class DbQueryParameterValidationException : Exception
    {
        public DbQueryParameterValidationException()
        {
        }

        public DbQueryParameterValidationException(string message) : base(message)
        {
        }

        public DbQueryParameterValidationException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DbQueryParameterValidationException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
