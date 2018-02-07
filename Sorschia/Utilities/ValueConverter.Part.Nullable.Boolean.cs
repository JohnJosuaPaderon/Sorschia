using System;

namespace Sorschia.Utilities
{
    partial class ValueConverter
    {
        /// <summary>
        /// Converts <see cref="object"/> to <see cref="Nullable"/>&lt;<see cref="bool"/>&gt;
        /// </summary>
        public static bool? ToNullableBoolean(object value)
        {
            return ConvertNullableBase(value, Convert.ToBoolean);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="Nullable"/>&lt;<see cref="bool"/>&gt; using the specified formatting information
        /// </summary>
        public static bool? ToNullableBoolean(object value, IFormatProvider formatProvider)
        {
            return ConvertNullableBase(value, formatProvider, Convert.ToBoolean);
        }

        /// <summary>
        /// Converts <see cref="string"/> to <see cref="Nullable"/>&lt;<see cref="bool"/>&gt;
        /// </summary>
        public static bool? ToNullableBoolean(string value)
        {
            return ConvertNullableBase(value, Convert.ToBoolean);
        }

        /// <summary>
        /// Converts <see cref="string"/> to <see cref="Nullable"/>&lt;<see cref="bool"/>&gt; using the specified formatting information
        /// </summary>
        public static bool? ToNullableBoolean(string value, IFormatProvider formatProvider)
        {
            return ConvertNullableBase(value, formatProvider, Convert.ToBoolean);
        }
    }
}
