namespace Sorschia.Convention
{
    public class EntityParameterName : ModelParameterName
    {
        public EntityParameterName(IParameterNameFormatter formatter) : base(formatter)
        {
            Id = formatter.Format(nameof(Id));
        }

        public string Id { get; }
    }
}
