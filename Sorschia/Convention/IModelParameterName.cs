﻿namespace Sorschia.Convention
{
    public interface IModelParameterName
    {
        string CreatedBy { get; }
        string DateCreated { get; }
        string ModifiedBy { get; }
        string DateModified { get; }
    }
}