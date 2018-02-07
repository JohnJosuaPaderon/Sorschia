using System;

namespace Sorschia.Utilities
{
    partial class ValueConverter
    {
        /// <summary>
        /// Converts <see cref="object"/> to <see cref="Nullable"/>&lt;<see cref="decimal"/>&gt;
        /// </summary>
        public static decimal? ToNullableDecimal(object value)
        {
            return ConvertNullableBase(value, Convert.ToDecimal);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="Nullable"/>&lt;<see cref="decimal"/>&gt; using the specified formatting information
        /// </summary>
        public static decimal? ToNullableDecimal(object value, IFormatProvider formatProvider)
        {
            return ConvertNullableBase(value, formatProvider, Convert.ToDecimal);
        }

        /// <summary>
        /// Converts <see cref="string"/> to <see cref="Nullable"/>&lt;<see cref="decimal"/>&gt;
        /// </summary>
        public static decimal? ToNullableDecimal(String value)
        {
            return ConvertNullableBase(value, Convert.ToDecimal);
        }

        /// <summary>
        /// Converts <see cref="string"/> to <see cref="Nullable"/>&lt;<see cref="decimal"/>&gt; using the specified formatting information
        /// </summary>
        public static decimal? ToNullableDecimal(string value, IFormatProvider formatProvider)
        {
            return ConvertNullableBase(value, formatProvider, Convert.ToDecimal);
        }
    }
}
