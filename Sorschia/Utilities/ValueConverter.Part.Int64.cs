using System;

namespace Sorschia.Utilities
{
    partial class ValueConverter
    {
        /// <summary>
        /// Converts <see cref="bool"/> to <see cref="long"/>
        /// </summary>
        public static long ToInt64(bool value)
        {
            return ConvertBase(value, Convert.ToInt64);
        }

        /// <summary>
        /// Converts <see cref="byte"/> to <see cref="long"/>
        /// </summary>
        public static object ToInt64(byte value)
        {
            return ConvertBase(value, Convert.ToInt64);
        }

        /// <summary>
        /// Converts <see cref="char"/> to <see cref="long"/>
        /// </summary>
        public static long ToInt64(char value)
        {
            return ConvertBase(value, Convert.ToInt64);
        }

        /// <summary>
        /// Converts <see cref="decimal"/> to <see cref="long"/>
        /// </summary>
        public static long ToInt64(decimal value)
        {
            return ConvertBase(value, Convert.ToInt64);
        }

        /// <summary>
        /// Converts <see cref="double"/> to <see cref="long"/>
        /// </summary>
        public static long ToInt64(double value)
        {
            return ConvertBase(value, Convert.ToInt64);
        }

        /// <summary>
        /// Converts <see cref="short"/> to <see cref="long"/>
        /// </summary>
        public static long ToInt64(short value)
        {
            return ConvertBase(value, Convert.ToInt64);
        }

        /// <summary>
        /// Converts <see cref="int"/> to <see cref="long"/>
        /// </summary>
        public static long ToInt64(int value)
        {
            return ConvertBase(value, Convert.ToInt64);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="long"/>
        /// </summary>
        public static long ToInt64(object value)
        {
            return ConvertBase(value, Convert.ToInt64);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="long"/> using the specified formatting information
        /// </summary>
        public static long ToInt64(object value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, Convert.ToInt64);
        }

        /// <summary>
        /// Converts <see cref="sbyte"/> to <see cref="long"/>
        /// </summary>
        public static long ToInt64(sbyte value)
        {
            return ConvertBase(value, Convert.ToInt64);
        }

        /// <summary>
        /// Converts <see cref="float"/> to <see cref="long"/>
        /// </summary>
        public static long ToInt64(float value)
        {
            return ConvertBase(value, Convert.ToInt64);
        }

        /// <summary>
        /// Converts <see cref="string"/> to <see cref="long"/>
        /// </summary>
        public static long ToInt64(string value)
        {
            return ConvertBase(value, Convert.ToInt64);
        }

        /// <summary>
        /// Converts <see cref="string"/> to <see cref="long"/> using the specified formatting information
        /// </summary>
        public static long ToInt64(string value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, Convert.ToInt64);
        }

        /// <summary>
        /// Converts <see cref="ushort"/> to <see cref="long"/>
        /// </summary>
        public static long ToInt64(ushort value)
        {
            return ConvertBase(value, Convert.ToInt64);
        }

        /// <summary>
        /// Converts <see cref="uint"/> to <see cref="long"/>
        /// </summary>
        public static long ToInt64(uint value)
        {
            return ConvertBase(value, Convert.ToInt64);
        }

        /// <summary>
        /// Converts <see cref="ulong"/> to <see cref="long"/>
        /// </summary>
        public static long ToInt64(ulong value)
        {
            return ConvertBase(value, Convert.ToInt64);
        }
    }
}
