using System;

namespace Sorschia
{
    partial class ValueConverter
    {
        /// <summary>
        /// Converts <see cref="object"/> to <see cref="DateTime"/>
        /// </summary>
        public static DateTime ToDateTime(object value)
        {
            return ConvertBase(value, Convert.ToDateTime);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="DateTime"/> using the specified formatting information
        /// </summary>
        public static DateTime ToDateTime(object value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, Convert.ToDateTime);
        }

        /// <summary>
        /// Converts <see cref="string"/> to <see cref="DateTime"/>
        /// </summary>
        public static DateTime ToDateTime(string value)
        {
            return ConvertBase(value, Convert.ToDateTime);
        }

        /// <summary>
        /// Converts <see cref="string"/> to <see cref="DateTime"/> using the specified formatting information
        /// </summary>
        public static DateTime ToDateTime(string value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, Convert.ToDateTime);
        }
    }
}
