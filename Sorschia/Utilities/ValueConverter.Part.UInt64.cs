using System;

namespace Sorschia.Utilities
{
    partial class ValueConverter
    {
        /// <summary>
        /// Converts <see cref="bool"/> to <see cref="ulong"/>
        /// </summary>
        public static ulong ToUInt64(bool value)
        {
            return ConvertBase(value, Convert.ToUInt64);
        }

        /// <summary>
        /// Converts <see cref="byte"/> to <see cref="ulong"/>
        /// </summary>
        public static ulong ToUInt64(byte value)
        {
            return ConvertBase(value, Convert.ToUInt64);
        }

        /// <summary>
        /// Converts <see cref="char"/> to <see cref="ulong"/>
        /// </summary>
        public static ulong ToUInt64(char value)
        {
            return ConvertBase(value, Convert.ToUInt64);
        }

        /// <summary>
        /// Converts <see cref="decimal"/> to <see cref="ulong"/>
        /// </summary>
        public static ulong ToUInt64(decimal value)
        {
            return ConvertBase(value, Convert.ToUInt64);
        }

        /// <summary>
        /// Converts <see cref="double"/> to <see cref="ulong"/>
        /// </summary>
        public static ulong ToUInt64(double value)
        {
            return ConvertBase(value, Convert.ToUInt64);
        }

        /// <summary>
        /// Converts <see cref="short"/> to <see cref="ulong"/>
        /// </summary>
        public static ulong ToUInt64(short value)
        {
            return ConvertBase(value, Convert.ToUInt64);
        }

        /// <summary>
        /// Converts <see cref="int"/> to <see cref="ulong"/>
        /// </summary>
        public static ulong ToUInt64(int value)
        {
            return ConvertBase(value, Convert.ToUInt64);
        }

        /// <summary>
        /// Converts <see cref="long"/> to <see cref="ulong"/>
        /// </summary>
        public static ulong ToUInt64(long value)
        {
            return ConvertBase(value, Convert.ToUInt64);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="ulong"/>
        /// </summary>
        public static ulong ToUInt64(object value)
        {
            return ConvertBase(value, Convert.ToUInt64);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="ulong"/> using the specified formatting information
        /// </summary>
        public static ulong ToUInt64(object value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, Convert.ToUInt64);
        }

        /// <summary>
        /// Converts <see cref="sbyte"/> to <see cref="ulong"/>
        /// </summary>
        public static ulong ToUInt64(sbyte value)
        {
            return ConvertBase(value, Convert.ToUInt64);
        }

        /// <summary>
        /// Converts <see cref="float"/> to <see cref="ulong"/>
        /// </summary>
        public static ulong ToUInt64(float value)
        {
            return ConvertBase(value, Convert.ToUInt64);
        }

        /// <summary>
        /// Converts <see cref="string"/> to <see cref="ulong"/>
        /// </summary>
        public static ulong ToUInt64(string value)
        {
            return ConvertBase(value, Convert.ToUInt64);
        }

        /// <summary>
        /// Converts <see cref="string"/> to <see cref="ulong"/> using the specified formatting information
        /// </summary>
        public static ulong ToUInt64(string value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, Convert.ToUInt64);
        }

        /// <summary>
        /// Converts <see cref="ushort"/> to <see cref="ulong"/>
        /// </summary>
        public static ulong ToUInt64(ushort value)
        {
            return ConvertBase(value, Convert.ToUInt64);
        }

        /// <summary>
        /// Converts <see cref="uint"/> to <see cref="ulong"/>
        /// </summary>
        public static ulong ToUInt64(uint value)
        {
            return ConvertBase(value, Convert.ToUInt64);
        }
    }
}
