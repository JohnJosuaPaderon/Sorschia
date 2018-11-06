using System;

namespace Sorschia
{
    partial class ValueConverter
    {
        /// <summary>
        /// Converts <see cref="object"/> to <see cref="Nullable"/>&lt;<see cref="float"/>&gt;
        /// </summary>
        public static float? ToNullableSingle(object value)
        {
            return ConvertNullableBase(value, Convert.ToSingle);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="Nullable"/>&lt;<see cref="float"/>&gt; using the specified formatting information
        /// </summary>
        public static float? ToNullableSingle(object value, IFormatProvider formatProvider)
        {
            return ConvertNullableBase(value, formatProvider, Convert.ToSingle);
        }

        /// <summary>
        /// Converts <see cref="string"/> to <see cref="Nullable"/>&lt;<see cref="float"/>&gt;
        /// </summary>
        public static float? ToNullableSingle(string value)
        {
            return ConvertNullableBase(value, Convert.ToSingle);
        }

        /// <summary>
        /// Converts <see cref="string"/> to <see cref="Nullable"/>&lt;<see cref="float"/>&gt; using the specified formatting information
        /// </summary>
        public static float? ToNullableSingle(string value, IFormatProvider formatProvider)
        {
            return ConvertNullableBase(value, formatProvider, Convert.ToSingle);
        }
    }
}
