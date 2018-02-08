namespace Sorschia.Entity
{
    /// <summary>
    /// Exposes validation methods for <see cref="EntityCollection{T, TId}"/> class
    /// </summary>
    internal sealed class EntityCollectionValidator<T, TId> where T : IEntity<TId>
    {
        /// <summary>
        /// Validates the id, must not be set to default
        /// </summary>
        public void ValidateId(TId id)
        {
            if (Equals(id, default(TId)))
            {
                throw new EntityCollectionValidationException($"Identifier of {typeof(T).FullName} is set to default.");
            }
        }

        /// <summary>
        /// Validates the entity, must not be set to default
        /// </summary>
        public void ValidateEntity(T entity)
        {
            if (Equals(entity, default(T)))
            {
                throw new EntityCollectionValidationException($"{typeof(T).FullName} is set to its default value.");
            }
        }
    }
}
