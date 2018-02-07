using System;

namespace Sorschia.Utilities
{
    partial class ValueConverter
    {
        /// <summary>
        /// Converts <see cref="object"/> to <see cref="Nullable"/>&lt;<see cref="ulong"/>&gt;
        /// </summary>
        public static ulong? ToNullableUInt64(object value)
        {
            return ConvertNullableBase(value, Convert.ToUInt64);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="Nullable"/>&lt;<see cref="ulong"/>&gt; using the specified formatting information
        /// </summary>
        public static ulong? ToNullableUInt64(object value, IFormatProvider formatProvider)
        {
            return ConvertNullableBase(value, formatProvider, Convert.ToUInt64);
        }

        /// <summary>
        /// Converts <see cref="string"/> to <see cref="Nullable"/>&lt;<see cref="ulong"/>&gt;
        /// </summary>
        public static ulong? ToNullableUInt64(string value)
        {
            return ConvertNullableBase(value, Convert.ToUInt64);
        }

        /// <summary>
        /// Converts <see cref="string"/> to <see cref="Nullable"/>&lt;<see cref="ulong"/>&gt; using the specified formatting information
        /// </summary>
        public static ulong? ToNullableUInt64(string value, IFormatProvider formatProvider)
        {
            return ConvertNullableBase(value, formatProvider, Convert.ToUInt64);
        }
    }
}
