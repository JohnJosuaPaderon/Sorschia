using System;

namespace Sorschia.Utilities
{
    partial class ValueConverter
    {
        /// <summary>
        /// Converts <see cref="object"/> to <see cref="Nullable"/>&lt;<see cref="sbyte"/>&gt;
        /// </summary>
        public static sbyte? ToNullableSByte(object value)
        {
            return ConvertNullableBase(value, Convert.ToSByte);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="Nullable"/>&lt;<see cref="sbyte"/>&gt; using the specified formatting information
        /// </summary>
        public static sbyte? ToNullableSByte(object value, IFormatProvider formatProvider)
        {
            return ConvertNullableBase(value, formatProvider, Convert.ToSByte);
        }

        /// <summary>
        /// Converts <see cref="string"/> to <see cref="Nullable"/>&lt;<see cref="sbyte"/>&gt;
        /// </summary>
        public static sbyte? ToNullableSByte(string value)
        {
            return ConvertNullableBase(value, Convert.ToSByte);
        }

        /// <summary>
        /// Converts <see cref="string"/> to <see cref="Nullable"/>&lt;<see cref="sbyte"/>&gt; using the specified formatting information
        /// </summary>
        public static sbyte? ToNullableSByte(string value, IFormatProvider formatProvider)
        {
            return ConvertNullableBase(value, formatProvider, Convert.ToSByte);
        }
    }
}
