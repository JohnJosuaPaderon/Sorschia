using System;

namespace Sorschia.Utilities
{
    partial class ValueConverter
    {
        /// <summary>
        /// Converts <see cref="object"/> to <see cref="Nullable"/>&lt;<see cref="int"/>&gt;
        /// </summary>
        public static int? ToNullableInt32(object value)
        {
            return ConvertNullableBase(value, Convert.ToInt32);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="Nullable"/>&lt;<see cref="int"/>&gt; using the specified formatting information
        /// </summary>
        public static int? ToNullableInt32(object value, IFormatProvider formatProvider)
        {
            return ConvertNullableBase(value, formatProvider, Convert.ToInt32);
        }

        /// <summary>
        /// Converts <see cref="string"/> to <see cref="Nullable"/>&lt;<see cref="int"/>&gt;
        /// </summary>
        public static int? ToNullableInt32(string value)
        {
            return ConvertNullableBase(value, Convert.ToInt32);
        }

        /// <summary>
        /// Converts <see cref="string"/> to <see cref="Nullable"/>&lt;<see cref="int"/>&gt; using the specified formatting information
        /// </summary>
        public static int? ToNullableInt32(string value, IFormatProvider formatProvider)
        {
            return ConvertNullableBase(value, formatProvider, Convert.ToInt32);
        }
    }
}
