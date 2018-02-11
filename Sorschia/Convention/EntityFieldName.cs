namespace Sorschia.Convention
{
    public class EntityFieldName
    {
        public EntityFieldName(IFieldNameFormatter formatter)
        {
            Id = formatter.Format(nameof(Id));
        }

        public string Id { get; }
    }
}
