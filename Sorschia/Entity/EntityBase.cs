namespace Sorschia.Entity
{
    /// <summary>
    /// Base-class for representational data models
    /// </summary>
    public abstract class EntityBase<TId> : IEntity<TId>
    {
        /// <summary>
        /// Identifier of data
        /// </summary>
        public TId Id { get; set; }

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
    }
}
