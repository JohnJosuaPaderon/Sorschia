using System;

namespace Sorschia.Utilities
{
    partial class ValueConverter
    {
        public static Guid ToGuid(object value)
        {
            return new Guid(ToString(value));
        }
    }
}
