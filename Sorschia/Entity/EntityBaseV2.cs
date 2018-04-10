namespace Sorschia.Entity
{
    public abstract class EntityBaseV2<TId> : IEntity<TId>
    {
        public EntityBaseV2(TId id)
        {
            Validator.Default(id, "Invalid id.");
        }

        public TId Id { get; }

        public static bool operator ==(EntityBaseV2<TId> left, EntityBaseV2<TId> right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(EntityBaseV2<TId> left, EntityBaseV2<TId> right)
        {
            return !(left == right);
        }

        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (GetType() != obj.GetType()) return false;

            if (obj is EntityBaseV2<TId> value)
            {
                return (Equals(Id, default(TId)) || Equals(value.Id, default(TId))) ? false : Equals(Id, value.Id);
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
