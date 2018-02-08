using System;
using System.Runtime.Serialization;

namespace Sorschia.Entity
{
    /// <summary>
    /// Error occured on validation on <see cref="EntityCollection{T, TId}"/>
    /// </summary>
    [Serializable]
    public class EntityCollectionValidationException : ValidationException
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public EntityCollectionValidationException()
        {
        }

        /// <summary>
        /// Initializes <see cref="EntityCollectionValidationException"/> with message
        /// </summary>
        public EntityCollectionValidationException(string message) : base(message)
        {
        }

        /// <summary>
        /// Initializes <see cref="EntityCollectionValidationException"/> with message and inner exception
        /// </summary>
        public EntityCollectionValidationException(string message, Exception inner) : base(message, inner)
        {
        }

        /// <summary>
        /// Initializes <see cref="EntityCollectionValidationException"/> with serialization information and streaming context
        /// </summary>
        protected EntityCollectionValidationException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
