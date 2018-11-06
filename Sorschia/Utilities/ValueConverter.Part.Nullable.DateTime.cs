using System;

namespace Sorschia
{
    partial class ValueConverter
    {
        /// <summary>
        /// Converts <see cref="object"/> to <see cref="Nullable"/>&lt;<see cref="DateTime"/>&gt;
        /// </summary>
        public static DateTime? ToNullableDateTime(object value)
        {
            return ConvertNullableBase(value, Convert.ToDateTime);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="Nullable"/>&lt;<see cref="DateTime"/>&gt; using the specified formatting information
        /// </summary>
        public static DateTime? ToNullableDateTime(object value, IFormatProvider formatProvider)
        {
            return ConvertNullableBase(value, formatProvider, Convert.ToDateTime);
        }

        /// <summary>
        /// Converts <see cref="string"/> to <see cref="Nullable"/>&lt;<see cref="DateTime"/>&gt;
        /// </summary>
        public static DateTime? ToNullableDateTime(String value)
        {
            return ConvertNullableBase(value, Convert.ToDateTime);
        }

        /// <summary>
        /// Converts <see cref="string"/> to <see cref="Nullable"/>&lt;<see cref="DateTime"/>&gt; using the specified formatting information
        /// </summary>
        public static DateTime? ToNullableDateTime(string value, IFormatProvider formatProvider)
        {
            return ConvertNullableBase(value, formatProvider, Convert.ToDateTime);
        }
    }
}
