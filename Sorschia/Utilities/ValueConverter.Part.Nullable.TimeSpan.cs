using System;

namespace Sorschia.Utilities
{
    partial class ValueConverter
    {
        /// <summary>
        /// Converts <see cref="object"/> to <see cref="Nullable"/>&lt;<see cref="TimeSpan"/>&gt;
        /// </summary>
        public static TimeSpan? ToNullableTimeSpan(object value)
        {
            var converted = ToNullableInt64(value);
            return converted == null ? null : new TimeSpan?(ToTimeSpan(converted));
        }
    }
}
