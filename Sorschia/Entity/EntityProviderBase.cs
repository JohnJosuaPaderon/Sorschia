namespace Sorschia
{
    public abstract class EntityProviderBase<T, TEntityLookUp>
        where TEntityLookUp : IEntityLookUp<T>
    {
        public EntityProviderBase(TEntityLookUp entityLookUp, string lookUpKeyPrefix = null)
        {
            EntityLookUp = entityLookUp;
            LookUpKeyPrefix = lookUpKeyPrefix;
        }

        private TEntityLookUp EntityLookUp { get; }
        private string LookUpKeyPrefix { get; }

        protected T TryGet(ref T backingField, string key)
        {
            if (backingField == null)
            {
                backingField = EntityLookUp.LookUp(TryFormatLookUpKey(key));
            }

            return backingField;
        }

        private string TryFormatLookUpKey(string key)
        {
            Validator.NullOrWhiteSpace(key, "Invalid look-up key.");

            if (string.IsNullOrWhiteSpace(LookUpKeyPrefix))
            {
                return key;
            }
            else
            {
                return $"{LookUpKeyPrefix}.{key}";
            }
        }
    }
}
