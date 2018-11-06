using System;

namespace Sorschia
{
    partial class ValueConverter
    {
        /// <summary>
        /// Converts <see cref="object"/> to <see cref="Nullable"/>&lt;<see cref="uint"/>&gt;
        /// </summary>
        public static uint? ToNullableUInt32(object value)
        {
            return ConvertNullableBase(value, Convert.ToUInt32);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="Nullable"/>&lt;<see cref="uint"/>&gt; using the specified formatting information
        /// </summary>
        public static uint? ToNullableUInt32(object value, IFormatProvider formatProvider)
        {
            return ConvertNullableBase(value, formatProvider, Convert.ToUInt32);
        }

        /// <summary>
        /// Converts <see cref="string"/> to <see cref="Nullable"/>&lt;<see cref="uint"/>&gt;
        /// </summary>
        public static uint? ToNullableUInt32(string value)
        {
            return ConvertNullableBase(value, Convert.ToUInt32);
        }

        /// <summary>
        /// Converts <see cref="string"/> to <see cref="Nullable"/>&lt;<see cref="uint"/>&gt; using the specified formatting information
        /// </summary>
        public static uint? ToNullableUInt32(string value, IFormatProvider formatProvider)
        {
            return ConvertNullableBase(value, formatProvider, Convert.ToUInt32);
        }
    }
}
