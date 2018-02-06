using System;

namespace Sorschia.Utilities
{
    partial class ValueConverter
    {
        /// <summary>
        /// Converts <see cref="byte"/> to <see cref="bool"/>
        /// </summary>
        public static bool ToBoolean(byte value)
        {
            return ConvertBase(value, Convert.ToBoolean);
        }

        /// <summary>
        /// Converts <see cref="decimal"/> to <see cref="bool"/>
        /// </summary>
        public static bool ToBoolean(decimal value)
        {
            return ConvertBase(value, Convert.ToBoolean);
        }

        /// <summary>
        /// Converts <see cref="double"/> to <see cref="bool"/>
        /// </summary>
        public static bool ToBoolean(double value)
        {
            return ConvertBase(value, Convert.ToBoolean);
        }

        /// <summary>
        /// Converts <see cref="short"/> to <see cref="bool"/>
        /// </summary>
        public static bool ToBoolean(short value)
        {
            return ConvertBase(value, Convert.ToBoolean);
        }

        /// <summary>
        /// Converts <see cref="int"/> to <see cref="bool"/>
        /// </summary>
        public static bool ToBoolean(int value)
        {
            return ConvertBase(value, Convert.ToBoolean);
        }

        /// <summary>
        /// Converts <see cref="long"/> to <see cref="bool"/>
        /// </summary>
        public static bool ToBoolean(long value)
        {
            return ConvertBase(value, Convert.ToBoolean);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="bool"/>
        /// </summary>
        public static bool ToBoolean(object value)
        {
            return ConvertBase(value, Convert.ToBoolean);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="bool"/> using the specified formatting information
        /// </summary>
        public static bool ToBoolean(object value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, Convert.ToBoolean);
        }

        /// <summary>
        /// Converts <see cref="sbyte"/> to <see cref="bool"/>
        /// </summary>
        public static bool ToBoolean(sbyte value)
        {
            return ConvertBase(value, Convert.ToBoolean);
        }

        /// <summary>
        /// Converts <see cref="float"/> to <see cref="bool"/>
        /// </summary>
        public static bool ToBoolean(float value)
        {
            return ConvertBase(value, Convert.ToBoolean);
        }

        /// <summary>
        /// Converts <see cref="string"/> to <see cref="bool"/>
        /// </summary>
        public static bool ToBoolean(string value)
        {
            return ConvertBase(value, Convert.ToBoolean);
        }

        /// <summary>
        /// Converts <see cref="string"/> to <see cref="bool"/> using the specified formatting information
        /// </summary>
        public static bool ToBoolean(string value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, Convert.ToBoolean);
        }

        /// <summary>
        /// Converts <see cref="ushort"/> to <see cref="bool"/>
        /// </summary>
        public static bool ToBoolean(ushort value)
        {
            return ConvertBase(value, Convert.ToBoolean);
        }

        /// <summary>
        /// Converts <see cref="uint"/> to <see cref="bool"/>
        /// </summary>
        public static bool ToBoolean(uint value)
        {
            return ConvertBase(value, Convert.ToBoolean);
        }

        /// <summary>
        /// Converts <see cref="ulong"/> to <see cref="bool"/>
        /// </summary>
        public static bool ToBoolean(ulong value)
        {
            return ConvertBase(value, Convert.ToBoolean);
        }
    }
}
