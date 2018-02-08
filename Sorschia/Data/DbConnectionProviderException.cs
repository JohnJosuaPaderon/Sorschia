using System;
using System.Runtime.Serialization;

namespace Sorschia.Data
{
    /// <summary>
    /// Error on occured when using <see cref="IDbConnectionProvider{T}"/>
    /// </summary>
    public class DbConnectionProviderException : Exception
    {
        public DbConnectionProviderException()
        {
        }

        public DbConnectionProviderException(string message) : base(message)
        {
        }

        public DbConnectionProviderException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DbConnectionProviderException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
