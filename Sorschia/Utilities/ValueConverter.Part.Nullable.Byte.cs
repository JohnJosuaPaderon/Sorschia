using System;

namespace Sorschia.Utilities
{
    partial class ValueConverter
    {
        /// <summary>
        /// Converts <see cref="object"/> to <see cref="Nullable"/>&lt;<see cref="byte"/>&gt;
        /// </summary>
        public static byte? ToNullableByte(object value)
        {
            return ConvertNullableBase(value, Convert.ToByte);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="Nullable"/>&lt;<see cref="byte"/>&gt; using the specified formatting information
        /// </summary>
        public static byte? ToNullableByte(object value, IFormatProvider formatProvider)
        {
            return ConvertNullableBase(value, formatProvider, Convert.ToByte);
        }

        /// <summary>
        /// Converts <see cref="string"/> to <see cref="Nullable"/>&lt;<see cref="Byte"/>&gt;
        /// </summary>
        public static Byte? ToNullableByte(string value)
        {
            return ConvertNullableBase(value, Convert.ToByte);
        }

        /// <summary>
        /// Converts <see cref="string"/> to <see cref="Nullable"/>&lt;<see cref="byte"/>&gt; using the specified formatting information
        /// </summary>
        public static byte? ToNullableByte(string value, IFormatProvider formatProvider)
        {
            return ConvertNullableBase(value, formatProvider, Convert.ToByte);
        }
    }
}
