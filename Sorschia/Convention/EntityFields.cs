namespace Sorschia.Convention
{
    public class EntityFields : ModelFields
    {
        public EntityFields(IFieldNameFormatter formatter) : base(formatter)
        {
            Id = formatter.Format(nameof(Id));
        }

        public string Id { get; }
    }
}
