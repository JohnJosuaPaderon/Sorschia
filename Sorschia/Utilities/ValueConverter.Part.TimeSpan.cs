using System;

namespace Sorschia.Utilities
{
    partial class ValueConverter
    {
        /// <summary>
        /// Converts <see cref="object"/> to <see cref="TimeSpan"/>
        /// </summary>
        public static TimeSpan ToTimeSpan(object value)
        {
            var converted = ToInt64(value);
            return new TimeSpan(converted);
        }
    }
}
