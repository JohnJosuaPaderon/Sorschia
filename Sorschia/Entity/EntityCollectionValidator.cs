namespace Sorschia
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
            Validator.Default(id, $"Identifier of {typeof(T).FullName} is set to default.");
        }

        /// <summary>
        /// Validates the entity, must not be set to default
        /// </summary>
        public void ValidateEntity(T entity)
        {
            Validator.Default(entity, $"{typeof(T).FullName} is set to its default value.");
        }
    }
}
