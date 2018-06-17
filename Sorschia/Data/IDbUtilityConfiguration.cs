using System;

namespace Sorschia.Data
{
    [Obsolete("This will be removed in the next version.")]
    public interface IDbUtilityConfiguration
    {
        string ConnectionString { get; }
    }
}
