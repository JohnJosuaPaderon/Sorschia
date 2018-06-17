using Sorschia.Entity;

namespace Sorschia
{
    public abstract class EntityModelBase<T, TId> : ModelBase<T>
       where T : IEntity<TId>
    {
        public EntityModelBase(T source, bool readOnlyId = false) : base(source)
        {
            Id = source.Id;
            ReadOnlyId = readOnlyId;
        }

        protected bool ReadOnlyId { get; }

        private TId _id;
        public TId Id
        {
            get { return _id; }
            set { SetProperty(ref _id, value); }
        }

        public override T GetUpdatedSource()
        {
            return base.GetUpdatedSource();
        }

        public static bool operator ==(EntityModelBase<T, TId> left, EntityModelBase<T, TId> right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(EntityModelBase<T, TId> left, EntityModelBase<T, TId> right)
        {
            return !(left == right);
        }

        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (GetType() != obj.GetType()) return false;

            if (obj is EntityModelBase<T, TId> value)
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
