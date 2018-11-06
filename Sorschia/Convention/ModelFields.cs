using System.Runtime.CompilerServices;

namespace Sorschia
{
    public class ModelFields
    {
        private IFieldNameFormatter _formatter;
        protected IFieldNameFormatter Formatter => ServiceStore.TryResolve(ref _formatter);

        private string _createdBy;
        public string CreatedBy => TryFormat(ref _createdBy);

        private string _dateCreated;
        public string DateCreated => TryFormat(ref _dateCreated);

        private string _modifiedBy;
        public string ModifiedBy => TryFormat(ref _modifiedBy);

        private string _dateModified;
        public string DateModified => TryFormat(ref _dateModified);

        private string _deletedBy;
        public string DeletedBy => TryFormat(ref _deletedBy);

        private string _dateDeleted;
        public string DateDeleted => TryFormat(ref _dateDeleted);

        private string _logBy;
        public string LogBy => TryFormat(ref _logBy);

        private string _logDate;
        public string LogDate => TryFormat(ref _logDate);

        protected string TryFormat(ref string backingField, [CallerMemberName]string value = null)
        {
            if (string.IsNullOrWhiteSpace(backingField))
            {
                backingField = Formatter.Format(value);
            }

            return backingField;
        }
    }
}
