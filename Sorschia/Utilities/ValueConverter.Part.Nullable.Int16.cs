using System;

namespace Sorschia
{
    partial class ValueConverter
    {
        /// <summary>
        /// Converts <see cref="object"/> to <see cref="Nullable"/>&lt;<see cref="short"/>&gt;
        /// </summary>
        public static short? ToNullableInt16(object value)
        {
            return ConvertNullableBase(value, Convert.ToInt16);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="Nullable"/>&lt;<see cref="short"/>&gt; using the specified formatting information
        /// </summary>
        public static short? ToNullableInt16(object value, IFormatProvider formatProvider)
        {
            return ConvertNullableBase(value, formatProvider, Convert.ToInt16);
        }

        /// <summary>
        /// Converts <see cref="string"/> to <see cref="Nullable"/>&lt;<see cref="short"/>&gt;
        /// </summary>
        public static short? ToNullableInt16(string value)
        {
            return ConvertNullableBase(value, Convert.ToInt16);
        }

        /// <summary>
        /// Converts <see cref="string"/> to <see cref="Nullable"/>&lt;<see cref="short"/>&gt; using the specified formatting information
        /// </summary>
        public static short? ToNullableInt16(string value, IFormatProvider formatProvider)
        {
            return ConvertNullableBase(value, formatProvider, Convert.ToInt16);
        }
    }
}
