using System;

namespace Sorschia
{
    partial class ValueConverter
    {
        public static Guid ToGuid(object value)
        {
            return new Guid(ToString(value));
        }
    }
}
