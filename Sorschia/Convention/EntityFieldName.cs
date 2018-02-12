namespace Sorschia.Convention
{
    public class EntityFieldName : ModelFieldName
    {
        public EntityFieldName(IFieldNameFormatter formatter) : base(formatter)
        {
            Id = formatter.Format(nameof(Id));
        }

        public string Id { get; }
    }
}
