using System;

namespace Sorschia.Utilities
{
    partial class ValueConverter
    {
        /// <summary>
        /// Converts <see cref="byte"/> to <see cref="char"/>
        /// </summary>
        public static char ToChar(byte value)
        {
            return ConvertBase(value, Convert.ToChar);
        }

        /// <summary>
        /// Converts <see cref="short"/> to <see cref="char"/>
        /// </summary>
        public static char ToChar(short value)
        {
            return ConvertBase(value, Convert.ToChar);
        }

        /// <summary>
        /// Converts <see cref="int"/> to <see cref="char"/>
        /// </summary>
        public static char ToChar(int value)
        {
            return ConvertBase(value, Convert.ToChar);
        }

        /// <summary>
        /// Converts <see cref="long"/> to <see cref="char"/>
        /// </summary>
        public static char ToChar(long value)
        {
            return ConvertBase(value, Convert.ToChar);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="char"/>
        /// </summary>
        public static char ToChar(object value)
        {
            return ConvertBase(value, Convert.ToChar);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="char"/> using the specified formatting information
        /// </summary>
        public static char ToChar(object value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, Convert.ToChar);
        }

        /// <summary>
        /// Converts <see cref="sbyte"/> to <see cref="char"/>
        /// </summary>
        public static char ToChar(sbyte value)
        {
            return ConvertBase(value, Convert.ToChar);
        }

        /// <summary>
        /// Converts <see cref="string"/> to <see cref="char"/>
        /// </summary>
        public static char ToChar(string value)
        {
            return ConvertBase(value, Convert.ToChar);
        }

        /// <summary>
        /// Converts <see cref="string"/> to <see cref="char"/> using the specified formatting information
        /// </summary>
        public static char ToChar(string value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, Convert.ToChar);
        }

        /// <summary>
        /// Converts <see cref="ushort"/> to <see cref="char"/>
        /// </summary>
        public static char ToChar(ushort value)
        {
            return ConvertBase(value, Convert.ToChar);
        }

        /// <summary>
        /// Converts <see cref="uint"/> to <see cref="char"/>
        /// </summary>
        public static char ToChar(uint value)
        {
            return ConvertBase(value, Convert.ToChar);
        }

        /// <summary>
        /// Converts <see cref="ulong"/> to <see cref="char"/>
        /// </summary>
        public static char ToChar(ulong value)
        {
            return ConvertBase(value, Convert.ToChar);
        }
    }
}
