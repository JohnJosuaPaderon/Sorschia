using System;
using System.Runtime.Serialization;

namespace Sorschia
{
    /// <summary>
    /// Error occured on validation
    /// </summary>
    [Serializable]
    public class ValidationException : Exception
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public ValidationException()
        {
        }

        /// <summary>
        /// Initializes <see cref="ValidationException"/> with message
        /// </summary>
        public ValidationException(string message) : base(message)
        {
        }

        /// <summary>
        /// Initializes <see cref="ValidationException"/> with message and inner exception
        /// </summary>
        public ValidationException(string message, Exception innerException) : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes <see cref="ValidationException"/> with serialization information and streaming context
        /// </summary>
        protected ValidationException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
