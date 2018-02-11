namespace Sorschia.Convention
{
    public class EntityParameterName
    {
        public EntityParameterName(IParameterNameFormatter formatter)
        {
            Id = formatter.Format(nameof(Id));
        }

        public string Id { get; }
    }
}
