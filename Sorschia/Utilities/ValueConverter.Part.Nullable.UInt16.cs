using System;

namespace Sorschia
{
    partial class ValueConverter
    {
        /// <summary>
        /// Converts <see cref="object"/> to <see cref="Nullable"/>&lt;<see cref="ushort"/>&gt;
        /// </summary>
        public static ushort? ToNullableUInt16(object value)
        {
            return ConvertNullableBase(value, Convert.ToUInt16);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="Nullable"/>&lt;<see cref="ushort"/>&gt; using the specified formatting information
        /// </summary>
        public static ushort? ToNullableUInt16(object value, IFormatProvider formatProvider)
        {
            return ConvertNullableBase(value, formatProvider, Convert.ToUInt16);
        }

        /// <summary>
        /// Converts <see cref="string"/> to <see cref="Nullable"/>&lt;<see cref="ushort"/>&gt;
        /// </summary>
        public static ushort? ToNullableUInt16(string value)
        {
            return ConvertNullableBase(value, Convert.ToUInt16);
        }

        /// <summary>
        /// Converts <see cref="string"/> to <see cref="Nullable"/>&lt;<see cref="ushort"/>&gt; using the specified formatting information
        /// </summary>
        public static ushort? ToNullableUInt16(string value, IFormatProvider formatProvider)
        {
            return ConvertNullableBase(value, formatProvider, Convert.ToUInt16);
        }
    }
}
