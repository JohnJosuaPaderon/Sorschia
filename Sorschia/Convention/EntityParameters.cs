namespace Sorschia
{
    public class EntityParameters : ModelParameters
    {
        private string _id;
        public string Id => TryFormat(ref _id);
    }
}
