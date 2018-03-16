using System.Collections;
using System.Collections.Generic;

namespace Sorschia.Entity
{
    /// <summary>
    /// A collection of entities with same type
    /// </summary>
    public class EntityCollection<T, TId> : IEntityCollection<T, TId>
        where T : IEntity<TId>
    {
        /// <summary>
        /// Initializes the class
        /// </summary>
        public EntityCollection()
        {
            _Source = new Dictionary<TId, T>();
            _Validator = new EntityCollectionValidator<T, TId>();
        }

        /// <summary>
        /// Read-only source of entities
        /// </summary>
        private readonly Dictionary<TId, T> _Source;
        
        /// <summary>
        /// Read-only validator
        /// </summary>
        private readonly EntityCollectionValidator<T, TId> _Validator;

        /// <summary>
        /// Gets or sets the entity using the specified identifier
        /// </summary>
        public T this[TId id]
        {
            get
            {
                _Validator.ValidateId(id);

                if (_Source.ContainsKey(id))
                {
                    return _Source[id];
                }
                else
                {
                    return default(T);
                }
            }
            set
            {
                _Validator.ValidateId(id);

                if (_Source.ContainsKey(id))
                {
                    _Source[id] = value;
                }
            }
        }

        /// <summary>
        /// Gets the count of entities
        /// </summary>
        public int Count => _Source.Count;

        /// <summary>
        /// Adds an entity to the collection
        /// </summary>
        public void Add(T entity)
        {
            _Validator.ValidateEntity(entity);
            _Validator.ValidateId(entity.Id);

            if (!_Source.ContainsKey(entity.Id))
            {
                _Source.Add(entity.Id, entity);
            }
        }

        /// <summary>
        /// Removes an entity from the collection
        /// </summary>
        public void Remove(T entity)
        {
            _Validator.ValidateEntity(entity);
            _Validator.ValidateId(entity.Id);

            if (_Source.ContainsKey(entity.Id))
            {
                _Source.Remove(entity.Id);
            }
        }

        /// <summary>
        /// Removes an entity from the collection using the identifier
        /// </summary>
        public void Remove(TId id)
        {
            _Validator.ValidateId(id);

            if (_Source.ContainsKey(id))
            {
                _Source.Remove(id);
            }
        }

        /// <summary>
        /// Clears all the entities in the collection
        /// </summary>
        public void Clear()
        {
            _Source.Clear();
        }

        /// <summary>
        /// Determines whether the entity exists in the collection
        /// </summary>
        public bool Contains(T entity)
        {
            _Validator.ValidateEntity(entity);
            _Validator.ValidateId(entity.Id);
            return _Source.ContainsKey(entity.Id);
        }

        /// <summary>
        /// Determines whether the entity with the specified identifier exists in the collection
        /// </summary>
        public bool Contains(TId id)
        {
            _Validator.ValidateId(id);
            return _Source.ContainsKey(id);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _Source.Values.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void AddOrUpdate(T entity)
        {
            _Validator.ValidateEntity(entity);
            _Validator.ValidateId(entity.Id);

            if (_Source.ContainsKey(entity.Id))
            {
                _Source[entity.Id] = entity;
            }
            else
            {
                _Source.Add(entity.Id, entity);
            }
        }
    }
}
