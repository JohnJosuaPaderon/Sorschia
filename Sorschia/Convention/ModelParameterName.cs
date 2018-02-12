namespace Sorschia.Convention
{
    public class ModelParameterName
    {
        public ModelParameterName(IParameterNameFormatter formatter)
        {
            CreatedBy = formatter.Format(nameof(CreatedBy));
            DateCreated = formatter.Format(nameof(DateCreated));
            ModifiedBy = formatter.Format(nameof(ModifiedBy));
            DateModified = formatter.Format(nameof(DateModified));
        }

        public string CreatedBy { get; }
        public string DateCreated { get; }
        public string ModifiedBy { get; }
        public string DateModified { get; }
    }
}
