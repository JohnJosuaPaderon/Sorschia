namespace Sorschia.Convention
{
    public class EntityParameters : ModelParameters
    {
        public EntityParameters(IParameterNameFormatter formatter) : base(formatter)
        {
            Id = formatter.Format(nameof(Id));
        }

        public string Id { get; }
    }
}
