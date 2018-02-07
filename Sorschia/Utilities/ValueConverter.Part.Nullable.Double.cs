using System;

namespace Sorschia.Utilities
{
    partial class ValueConverter
    {
        /// <summary>
        /// Converts <see cref="object"/> to <see cref="Nullable"/>&lt;<see cref="double"/>&gt;
        /// </summary>
        public static double? ToNullableDouble(object value)
        {
            return ConvertNullableBase(value, Convert.ToDouble);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="Nullable"/>&lt;<see cref="double"/>&gt; using the specified formatting information
        /// </summary>
        public static double? ToNullableDouble(object value, IFormatProvider formatProvider)
        {
            return ConvertNullableBase(value, formatProvider, Convert.ToDouble);
        }

        /// <summary>
        /// Converts <see cref="string"/> to <see cref="Nullable"/>&lt;<see cref="double"/>&gt;
        /// </summary>
        public static double? ToNullableDouble(string value)
        {
            return ConvertNullableBase(value, Convert.ToDouble);
        }

        /// <summary>
        /// Converts <see cref="string"/> to <see cref="Nullable"/>&lt;<see cref="double"/>&gt; using the specified formatting information
        /// </summary>
        public static double? ToNullableDouble(string value, IFormatProvider formatProvider)
        {
            return ConvertNullableBase(value, formatProvider, Convert.ToDouble);
        }
    }
}
