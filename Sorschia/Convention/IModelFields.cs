﻿namespace Sorschia
{
    public interface IModelFields
    {
        string CreatedBy { get; }
        string DateCreated { get; }
        string ModifiedBy { get; }
        string DateModified { get; }
        string DeletedBy { get; }
        string DateDeleted { get; }
        string LogBy { get; }
        string LogDate { get; }
    }
}
