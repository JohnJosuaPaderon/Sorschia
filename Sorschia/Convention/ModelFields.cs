namespace Sorschia.Convention
{
    public class ModelFields
    {
        public ModelFields(IFieldNameFormatter formatter)
        {
            CreatedBy = formatter.Format(nameof(CreatedBy));
            DateCreated = formatter.Format(nameof(DateCreated));
            ModifiedBy = formatter.Format(nameof(ModifiedBy));
            DateModified = formatter.Format(nameof(DateModified));
            DeletedBy = formatter.Format(nameof(DeletedBy));
            DateDeleted = formatter.Format(nameof(DateDeleted));
            LogBy = formatter.Format(nameof(LogBy));
            LogDate = formatter.Format(nameof(LogDate));
        }

        public string CreatedBy { get; }
        public string DateCreated { get; }
        public string ModifiedBy { get; }
        public string DateModified { get; }
        public string DeletedBy { get; }
        public string DateDeleted { get; }
        public string LogBy { get; }
        public string LogDate { get; }
    }
}
