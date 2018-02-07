using System;

namespace Sorschia.Utilities
{
    partial class ValueConverter
    {
        /// <summary>
        /// Converts <see cref="object"/> to <see cref="Nullable"/>&lt;<see cref="long"/>&gt;
        /// </summary>
        public static long? ToNullableInt64(object value)
        {
            return ConvertNullableBase(value, Convert.ToInt64);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="Nullable"/>&lt;<see cref="long"/>&gt; using the specified formatting information
        /// </summary>
        public static long? ToNullableInt64(object value, IFormatProvider formatProvider)
        {
            return ConvertNullableBase(value, formatProvider, Convert.ToInt64);
        }

        /// <summary>
        /// Converts <see cref="string"/> to <see cref="Nullable"/>&lt;<see cref="long"/>&gt;
        /// </summary>
        public static long? ToNullableInt64(string value)
        {
            return ConvertNullableBase(value, Convert.ToInt64);
        }

        /// <summary>
        /// Converts <see cref="string"/> to <see cref="Nullable"/>&lt;<see cref="long"/>&gt; using the specified formatting information
        /// </summary>
        public static long? ToNullableInt64(string value, IFormatProvider formatProvider)
        {
            return ConvertNullableBase(value, formatProvider, Convert.ToInt64);
        }
    }
}
