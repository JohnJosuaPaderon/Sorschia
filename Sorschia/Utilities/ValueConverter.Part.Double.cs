using System;

namespace Sorschia.Utilities
{
    partial class ValueConverter
    {
        /// <summary>
        /// Converts <see cref="bool"/> to <see cref="double"/>
        /// </summary>
        public static double ToDouble(bool value)
        {
            return ConvertBase(value, Convert.ToDouble);
        }

        /// <summary>
        /// Converts <see cref="byte"/> to <see cref="double"/>
        /// </summary>
        public static double ToDouble(byte value)
        {
            return ConvertBase(value, Convert.ToDouble);
        }

        /// <summary>
        /// Converts <see cref="decimal"/> to <see cref="double"/>
        /// </summary>
        public static double ToDouble(decimal value)
        {
            return ConvertBase(value, Convert.ToDouble);
        }

        /// <summary>
        /// Converts <see cref="short"/> to <see cref="double"/>
        /// </summary>
        public static double ToDouble(short value)
        {
            return ConvertBase(value, Convert.ToDouble);
        }

        /// <summary>
        /// Converts <see cref="int"/> to <see cref="double"/>
        /// </summary>
        public static double ToDouble(int value)
        {
            return ConvertBase(value, Convert.ToDouble);
        }

        /// <summary>
        /// Converts <see cref="long"/> to <see cref="double"/>
        /// </summary>
        public static double ToDouble(long value)
        {
            return ConvertBase(value, Convert.ToDouble);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="double"/>
        /// </summary>
        public static double ToDouble(object value)
        {
            return ConvertBase(value, Convert.ToDouble);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="double"/> using the specified formatting information
        /// </summary>
        public static double ToDouble(object value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, Convert.ToDouble);
        }

        /// <summary>
        /// Converts <see cref="sbyte"/> to <see cref="double"/>
        /// </summary>
        public static double ToDouble(sbyte value)
        {
            return ConvertBase(value, Convert.ToDouble);
        }

        /// <summary>
        /// Converts <see cref="float"/> to <see cref="double"/>
        /// </summary>
        public static double ToDouble(float value)
        {
            return ConvertBase(value, Convert.ToDouble);
        }

        /// <summary>
        /// Converts <see cref="string"/> to <see cref="double"/>
        /// </summary>
        public static double ToDouble(string value)
        {
            return ConvertBase(value, Convert.ToDouble);
        }

        /// <summary>
        /// Converts <see cref="string"/> to <see cref="double"/> using the specified formatting information
        /// </summary>
        public static double ToDouble(string value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, Convert.ToDouble);
        }

        /// <summary>
        /// Converts <see cref="ushort"/> to <see cref="double"/>
        /// </summary>
        public static double ToDouble(ushort value)
        {
            return ConvertBase(value, Convert.ToDouble);
        }

        /// <summary>
        /// Converts <see cref="uint"/> to <see cref="double"/>
        /// </summary>
        public static double ToDouble(uint value)
        {
            return ConvertBase(value, Convert.ToDouble);
        }

        /// <summary>
        /// Converts <see cref="ulong"/> to <see cref="double"/>
        /// </summary>
        public static double ToDouble(ulong value)
        {
            return ConvertBase(value, Convert.ToDouble);
        }
    }
}
