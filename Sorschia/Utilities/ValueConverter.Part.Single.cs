using System;

namespace Sorschia
{
    partial class ValueConverter
    {
        /// <summary>
        /// Converts <see cref="bool"/> to <see cref="float"/>
        /// </summary>
        public static float ToSingle(bool value)
        {
            return ConvertBase(value, Convert.ToSingle);
        }

        /// <summary>
        /// Converts <see cref="byte"/> to <see cref="float"/>
        /// </summary>
        public static float ToSingle(byte value)
        {
            return ConvertBase(value, Convert.ToSingle);
        }

        /// <summary>
        /// Converts <see cref="decimal"/> to <see cref="float"/>
        /// </summary>
        public static float ToSingle(decimal value)
        {
            return ConvertBase(value, Convert.ToSingle);
        }

        /// <summary>
        /// Converts <see cref="double"/> to <see cref="float"/>
        /// </summary>
        public static float ToSingle(double value)
        {
            return ConvertBase(value, Convert.ToSingle);
        }

        /// <summary>
        /// Converts <see cref="short"/> to <see cref="float"/>
        /// </summary>
        public static float ToSingle(short value)
        {
            return ConvertBase(value, Convert.ToSingle);
        }

        /// <summary>
        /// Converts <see cref="int"/> to <see cref="float"/>
        /// </summary>
        public static float ToSingle(int value)
        {
            return ConvertBase(value, Convert.ToSingle);
        }

        /// <summary>
        /// Converts <see cref="long"/> to <see cref="float"/>
        /// </summary>
        public static float ToSingle(long value)
        {
            return ConvertBase(value, Convert.ToSingle);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="float"/>
        /// </summary>
        public static float ToSingle(object value)
        {
            return ConvertBase(value, Convert.ToSingle);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="float"/> using the specified formatting information
        /// </summary>
        public static float ToSingle(object value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, Convert.ToSingle);
        }

        /// <summary>
        /// Converts <see cref="sbyte"/> to <see cref="float"/>
        /// </summary>
        public static float ToSingle(sbyte value)
        {
            return ConvertBase(value, Convert.ToSingle);
        }

        /// <summary>
        /// Converts <see cref="string"/> to <see cref="float"/>
        /// </summary>
        public static float ToSingle(string value)
        {
            return ConvertBase(value, Convert.ToSingle);
        }

        /// <summary>
        /// Converts <see cref="string"/> to <see cref="float"/> using the specified formatting information
        /// </summary>
        public static float ToSingle(string value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, Convert.ToSingle);
        }

        /// <summary>
        /// Converts <see cref="ushort"/> to <see cref="float"/>
        /// </summary>
        public static float ToSingle(ushort value)
        {
            return ConvertBase(value, Convert.ToSingle);
        }

        /// <summary>
        /// Converts <see cref="uint"/> to <see cref="float"/>
        /// </summary>
        public static float ToSingle(uint value)
        {
            return ConvertBase(value, Convert.ToSingle);
        }

        /// <summary>
        /// Converts <see cref="ulong"/> to <see cref="float"/>
        /// </summary>
        public static float ToSingle(ulong value)
        {
            return ConvertBase(value, Convert.ToSingle);
        }
    }
}
