using System;

namespace Sorschia
{
    /// <summary>
    /// Base-class for representational data models
    /// </summary>
    public abstract class EntityBase<TId> : IEntity<TId>
    {
        public EntityBase()
        {

        }

        public EntityBase(TId id)
        {
            Id = id;
            ReadOnlyId = true;
        }

        private TId _id;

        /// <summary>
        /// Identifier of data
        /// </summary>
        public TId Id
        {
            get { return _id; }
            set
            {
                if (ReadOnlyId)
                {
                    throw new InvalidOperationException("Id is read-only.");
                }
                else
                {
                    if (!Equals(_id, value))
                    {
                        _id = value;
                    }
                }
            }
        }

        protected bool ReadOnlyId { get; set; }

        /// <summary>
        /// Determines whether the left and right entity of the same type are equal
        /// </summary>
        public static bool operator ==(EntityBase<TId> left, EntityBase<TId> right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Determines whether the left and right entity of the same type are not equal
        /// </summary>
        public static bool operator !=(EntityBase<TId> left, EntityBase<TId> right)
        {
            return !(left == right);
        }

        /// <summary>
        /// Determines whether the instance is equal to the specified object
        /// </summary>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (GetType() != obj.GetType()) return false;

            if (obj is EntityBase<TId> value)
            {
                return (Equals(Id, default(TId)) || Equals(value.Id, default(TId))) ? false : Equals(Id, value.Id);
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Serves as default hash function
        /// </summary>
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        protected void Set<T>(ref T backingField, T value)
        {
            if (!Equals(backingField, value))
            {
                backingField = value;
            }
        }

        protected void Set<T>(ref T backingField, T value, Action<T> onChanged)
        {
            if (!Equals(backingField, value))
            {
                backingField = value;
                onChanged(value);
            }
        }

        protected void Set<T>(ref T backingField, T value, Func<T, bool> validate)
        {
            if (!Equals(backingField, value))
            {
                if (validate(value))
                {
                    backingField = value;
                }
                else
                {
                    throw new ValidationException("Failed on validating property.", ValidationType.Default);
                }
            }
        }

        protected void Set<T>(ref T backingField, T value, Func<T, bool> validate, Action<T> onChanged)
        {
            if (!Equals(backingField, value))
            {
                if (validate(value))
                {
                    backingField = value;
                    onChanged(value);
                }
                else
                {
                    throw new ValidationException("Failed on validating property.", ValidationType.Default);
                }
            }
        }

        protected void Set<T>(ref T backingField, T value, Func<T, bool> validate, string validationFailureMessage)
        {
            if (!Equals(backingField, value))
            {
                if (validate(value))
                {
                    backingField = value;
                }
                else
                {
                    throw new ValidationException(validationFailureMessage, ValidationType.Default);
                }
            }
        }

        protected void Set<T>(ref T backingField, T value, Func<T, bool> validate, string validationFailureMessage, Action<T> onChanged)
        {
            if (!Equals(backingField, value))
            {
                if (validate(value))
                {
                    backingField = value;
                    onChanged(value);
                }
                else
                {
                    throw new ValidationException(validationFailureMessage, ValidationType.Default);
                }
            }
        }
    }

    public abstract class EntityBase : IEntity<Guid>
    {
        public EntityBase()
        {
            Id = Guid.NewGuid();
        }

        public EntityBase(Guid id)
        {
            Validator.Default(id, "Invalid id.");
            Id = id;
        }

        public Guid Id { get; }

        public static bool operator ==(EntityBase left, EntityBase right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(EntityBase left, EntityBase right)
        {
            return !(left == right);
        }

        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (GetType() != obj.GetType()) return false;

            if (obj is EntityBase value)
            {
                return (Equals(Id, default(Guid)) || Equals(value.Id, default(Guid))) ? false : Equals(Id, value.Id);
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
