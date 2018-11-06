using System.Collections.Generic;

namespace Sorschia
{
    /// <summary>
    /// Represents a collection of entities with same type
    /// </summary>
    public interface IEntityCollection<T, TId> : IEnumerable<T>
        where T : IEntity<TId>
    {
        /// <summary>
        /// Gets or sets the entity using the specified identifier
        /// </summary>
        T this[TId id] { get; set; }

        /// <summary>
        /// Gets the count of entities
        /// </summary>
        int Count { get; }

        /// <summary>
        /// Adds an entity to the collection
        /// </summary>
        void Add(T entity);

        /// <summary>
        /// Removes an entity from the collection
        /// </summary>
        void Remove(T entity);

        /// <summary>
        /// Removes an entity from the collection using the identifier
        /// </summary>
        void Remove(TId id);

        /// <summary>
        /// Clears all the entities in the collection
        /// </summary>
        void Clear();

        /// <summary>
        /// Determines whether the entity exists in the collection
        /// </summary>
        bool Contains(T entity);

        /// <summary>
        /// Determines whether the entity with the specified identifier exists in the collection
        /// </summary>
        bool Contains(TId id);
        void AddOrUpdate(T entity);
    }
}
