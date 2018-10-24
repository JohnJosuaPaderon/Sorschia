namespace Sorschia.Convention
{
    public class EntityFields : ModelFields
    {
        private string _id;
        public string Id => TryFormat(ref _id);
    }
}
