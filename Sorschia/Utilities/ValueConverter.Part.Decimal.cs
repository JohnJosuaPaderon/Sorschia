using System;

namespace Sorschia.Utilities
{
    partial class ValueConverter
    {
        /// <summary>
        /// Converts <see cref="bool"/> to <see cref="decimal"/>
        /// </summary>
        public static decimal ToDecimal(bool value)
        {
            return ConvertBase(value, Convert.ToDecimal);
        }

        /// <summary>
        /// Converts <see cref="byte"/> to <see cref="decimal"/>
        /// </summary>
        public static Decimal ToDecimal(byte value)
        {
            return ConvertBase(value, Convert.ToDecimal);
        }

        /// <summary>
        /// Converts <see cref="double"/> to <see cref="decimal"/>
        /// </summary>
        public static decimal ToDecimal(double value)
        {
            return ConvertBase(value, Convert.ToDecimal);
        }

        /// <summary>
        /// Converts <see cref="short"/> to <see cref="decimal"/>
        /// </summary>
        public static decimal ToDecimal(short value)
        {
            return ConvertBase(value, Convert.ToDecimal);
        }

        /// <summary>
        /// Converts <see cref="int"/> to <see cref="decimal"/>
        /// </summary>
        public static decimal ToDecimal(int value)
        {
            return ConvertBase(value, Convert.ToDecimal);
        }

        /// <summary>
        /// Converts <see cref="long"/> to <see cref="decimal"/>
        /// </summary>
        public static decimal ToDecimal(long value)
        {
            return ConvertBase(value, Convert.ToDecimal);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="decimal"/>
        /// </summary>
        public static decimal ToDecimal(object value)
        {
            return ConvertBase(value, Convert.ToDecimal);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="decimal"/> using the specified formatting information
        /// </summary>
        public static decimal ToDecimal(object value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, Convert.ToDecimal);
        }

        /// <summary>
        /// Converts <see cref="sbyte"/> to <see cref="decimal"/>
        /// </summary>
        public static decimal ToDecimal(sbyte value)
        {
            return ConvertBase(value, Convert.ToDecimal);
        }

        /// <summary>
        /// Converts <see cref="float"/> to <see cref="decimal"/>
        /// </summary>
        public static decimal ToDecimal(float value)
        {
            return ConvertBase(value, Convert.ToDecimal);
        }

        /// <summary>
        /// Converts <see cref="string"/> to <see cref="decimal"/>
        /// </summary>
        public static decimal ToDecimal(string value)
        {
            return ConvertBase(value, Convert.ToDecimal);
        }

        /// <summary>
        /// Converts <see cref="string"/> to <see cref="decimal"/> using the specified formatting information
        /// </summary>
        public static decimal ToDecimal(string value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, Convert.ToDecimal);
        }

        /// <summary>
        /// Converts <see cref="ushort"/> to <see cref="decimal"/>
        /// </summary>
        public static decimal ToDecimal(ushort value)
        {
            return ConvertBase(value, Convert.ToDecimal);
        }

        /// <summary>
        /// Converts <see cref="uint"/> to <see cref="decimal"/>
        /// </summary>
        public static decimal ToDecimal(uint value)
        {
            return ConvertBase(value, Convert.ToDecimal);
        }

        /// <summary>
        /// Converts <see cref="ulong"/> to <see cref="decimal"/>
        /// </summary>
        public static decimal ToDecimal(ulong value)
        {
            return ConvertBase(value, Convert.ToDecimal);
        }   
    }
}
