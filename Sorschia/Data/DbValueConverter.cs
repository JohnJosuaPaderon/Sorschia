using Sorschia.Utilities;
using System;
using System.IO;

namespace Sorschia.Data
{
    /// <summary>
    /// Exposes functions that converts database values to .NET types.
    /// </summary>
    public static class DbValueConverter
    {
        /// <summary>
        /// Determines whether the value is equal to <see cref="DBNull.Value"/> or default.
        /// </summary>
        private static bool IsDbNullOrDefault(object value)
        {
            return value == null || Equals(DBNull.Value, value);
        }

        /// <summary>
        /// Base-conversion that requires the value and a function that actually converts the value
        /// </summary>
        private static T ConvertBase<T>(object value, Func<object, T> convert)
        {
            return IsDbNullOrDefault(value) ? default(T) : convert(value);
        }

        /// <summary>
        /// Base-conversion that requires the value, a formatting information and a function that actually converts the value using the specified formatting information
        /// </summary>
        private static T ConvertBase<T>(object value, IFormatProvider formatProvider, Func<object, IFormatProvider, T> convert)
        {
            return IsDbNullOrDefault(value) ? default(T) : convert(value, formatProvider);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="bool"/>
        /// </summary>
        public static bool ToBoolean(object value)
        {
            return ConvertBase(value, ValueConverter.ToBoolean);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="bool"/> using the specified formatting information
        /// </summary>
        public static bool ToBoolean(object value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, ValueConverter.ToBoolean);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="byte"/>
        /// </summary>
        public static byte ToByte(object value)
        {
            return ConvertBase(value, ValueConverter.ToByte);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="byte"/> using the specified formatting information
        /// </summary>
        public static byte ToByte(object value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, ValueConverter.ToByte);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="byte[]"/>
        /// </summary>
        public static byte[] ToByteArray(object value)
        {
            return ConvertBase(value, ValueConverter.ToByteArray);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="char"/>
        /// </summary>
        public static char ToChar(object value)
        {
            return ConvertBase(value, ValueConverter.ToChar);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="char"/> using the specified formatting information
        /// </summary>
        public static char ToChar(object value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, ValueConverter.ToChar);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="DateTime"/>
        /// </summary>
        public static DateTime ToDateTime(object value)
        {
            return ConvertBase(value, ValueConverter.ToDateTime);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="DateTime"/> using the specified formatting information
        /// </summary>
        public static DateTime ToDateTime(object value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, ValueConverter.ToDateTime);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="decimal"/>
        /// </summary>
        public static decimal ToDecimal(object value)
        {
            return ConvertBase(value, ValueConverter.ToDecimal);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="decimal"/> using the specified formatting information
        /// </summary>
        public static decimal ToDecimal(object value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, ValueConverter.ToDecimal);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="double"/>
        /// </summary>
        public static double ToDouble(object value)
        {
            return ConvertBase(value, ValueConverter.ToDouble);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="double"/> using the specified formatting information
        /// </summary>
        public static double ToDouble(object value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, ValueConverter.ToDouble);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="short"/>
        /// </summary>
        public static short ToInt16(object value)
        {
            return ConvertBase(value, ValueConverter.ToInt16);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="short"/> using the specified formatting information
        /// </summary>
        public static short ToInt16(object value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, ValueConverter.ToInt16);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="int"/>
        /// </summary>
        public static int ToInt32(object value)
        {
            return ConvertBase(value, ValueConverter.ToInt32);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="int"/> using the specified formatting information
        /// </summary>
        public static int ToInt32(object value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, ValueConverter.ToInt32);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="long"/>
        /// </summary>
        public static long ToInt64(object value)
        {
            return ConvertBase(value, ValueConverter.ToInt64);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="long"/> using the specified formatting information
        /// </summary>
        public static long ToInt64(object value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, ValueConverter.ToInt64);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="bool?"/>
        /// </summary>
        public static bool? ToNullableBoolean(object value)
        {
            return ConvertBase(value, ValueConverter.ToNullableBoolean);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="bool?"/> using the specified formatting information
        /// </summary>
        public static bool? ToNullableBoolean(object value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, ValueConverter.ToNullableBoolean);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="byte?"/>
        /// </summary>
        public static byte? ToNullableByte(object value)
        {
            return ConvertBase(value, ValueConverter.ToNullableByte);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="byte?"/> using the specified formatting information
        /// </summary>
        public static byte? ToNullableByte(object value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, ValueConverter.ToNullableByte);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="char?"/>
        /// </summary>
        public static char? ToNullableChar(object value)
        {
            return ConvertBase(value, ValueConverter.ToNullableChar);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="char?"/> using the specified formatting information
        /// </summary>
        public static char? ToNullableChar(object value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, ValueConverter.ToNullableChar);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="DateTime?"/>
        /// </summary>
        public static DateTime? ToNullableDateTime(object value)
        {
            return ConvertBase(value, ValueConverter.ToNullableDateTime);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="DateTime?"/> using the specified formatting information
        /// </summary>
        public static DateTime? ToNullableDateTime(object value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, ValueConverter.ToNullableDateTime);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="decimal?"/>
        /// </summary>
        public static decimal? ToNullableDecimal(object value)
        {
            return ConvertBase(value, ValueConverter.ToNullableDecimal);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="decimal?"/> using the specified formatting information
        /// </summary>
        public static decimal? ToNullableDecimal(object value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, ValueConverter.ToNullableDecimal);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="double?"/>
        /// </summary>
        public static double? ToNullableDouble(object value)
        {
            return ConvertBase(value, ValueConverter.ToNullableDouble);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="double?"/> using the specified formatting information
        /// </summary>
        public static double? ToNullableDouble(object value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, ValueConverter.ToNullableDouble);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="short?"/>
        /// </summary>
        public static short? ToNullableInt16(object value)
        {
            return ConvertBase(value, ValueConverter.ToNullableInt16);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="short?"/> using the specified formatting information
        /// </summary>
        public static short? ToNullableInt16(object value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, ValueConverter.ToNullableInt16);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="int?"/>
        /// </summary>
        public static int? ToNullableInt32(object value)
        {
            return ConvertBase(value, ValueConverter.ToNullableInt32);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="int?"/> using the specified formatting information
        /// </summary>
        public static int? ToNullableInt32(object value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, ValueConverter.ToNullableInt32);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="long?"/>
        /// </summary>
        public static long? ToNullableInt64(object value)
        {
            return ConvertBase(value, ValueConverter.ToNullableInt64);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="long?"/> using the specified formatting information
        /// </summary>
        public static long? ToNullableInt64(object value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, ValueConverter.ToNullableInt64);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="sbyte?"/>
        /// </summary>
        public static sbyte? ToNullableSByte(object value)
        {
            return ConvertBase(value, ValueConverter.ToNullableSByte);
        }
        /// <summary>
        /// Converts <see cref="object"/> to <see cref="sbyte?"/> using the specified formatting information
        /// </summary>
        public static sbyte? ToNullableSByte(object value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, ValueConverter.ToNullableSByte);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="float?"/>
        /// </summary>
        public static float? ToNullableSingle(object value)
        {
            return ConvertBase(value, ValueConverter.ToNullableSingle);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="float?"/> using the specified formatting information
        /// </summary>
        public static float? ToNullableSingle(object value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, ValueConverter.ToNullableSingle);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="TimeSpan?"/>
        /// </summary>
        public static TimeSpan? ToNullableTimeSpan(object value)
        {
            return ConvertBase(value, ValueConverter.ToNullableTimeSpan);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="ushort?"/>
        /// </summary>
        public static ushort? ToNullableUInt16(object value)
        {
            return ConvertBase(value, ValueConverter.ToNullableUInt16);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="ushort?"/> using the specified formatting information
        /// </summary>
        public static ushort? ToNullableUInt16(object value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, ValueConverter.ToNullableUInt16);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="uint?"/>
        /// </summary>
        public static uint? ToNullableUInt32(object value)
        {
            return ConvertBase(value, ValueConverter.ToNullableUInt32);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="uint?"/> using the specified formatting information
        /// </summary>
        public static uint? ToNullableUInt32(object value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, ValueConverter.ToNullableUInt32);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="ulong?"/>
        /// </summary>
        public static ulong? ToNullableUInt64(object value)
        {
            return ConvertBase(value, ValueConverter.ToNullableUInt64);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="ulong?"/> using the specified formatting information
        /// </summary>
        public static ulong? ToNullableUInt64(object value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, ValueConverter.ToNullableUInt64);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="sbyte"/>
        /// </summary>
        public static sbyte ToSByte(object value)
        {
            return ConvertBase(value, ValueConverter.ToSByte);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="sbyte"/> using the specified formatting information
        /// </summary>
        public static sbyte ToSByte(object value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, ValueConverter.ToSByte);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="float"/>
        /// </summary>
        public static float ToSingle(object value)
        {
            return ConvertBase(value, ValueConverter.ToSingle);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="float"/> using the specified formatting information
        /// </summary>
        public static float ToSingle(object value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, ValueConverter.ToSingle);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="Stream"/>
        /// </summary>
        public static Stream ToStream(object value)
        {
            return ConvertBase(value, ValueConverter.ToStream);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="string"/>
        /// </summary>
        public static string ToString(object value)
        {
            return ConvertBase(value, ValueConverter.ToString);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="string"/> using the specified formatting information
        /// </summary>
        public static string ToString(object value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, ValueConverter.ToString);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="TimeSpan"/>
        /// </summary>
        public static TimeSpan ToTimeSpan(object value)
        {
            return ConvertBase(value, ValueConverter.ToTimeSpan);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="ushort"/>
        /// </summary>
        public static ushort ToUInt16(object value)
        {
            return ConvertBase(value, ValueConverter.ToUInt16);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="ushort"/> using the specified formatting information
        /// </summary>
        public static ushort ToUInt16(object value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, ValueConverter.ToUInt16);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="uint"/>
        /// </summary>
        public static uint ToUInt32(object value)
        {
            return ConvertBase(value, ValueConverter.ToUInt32);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="uint"/> using the specified formatting information
        /// </summary>
        public static uint ToUInt32(object value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, ValueConverter.ToUInt32);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="ulong"/>
        /// </summary>
        public static ulong ToUInt64(object value)
        {
            return ConvertBase(value, ValueConverter.ToUInt64);
        }

        /// <summary>
        /// Converts <see cref="object"/> to <see cref="ulong"/> using the specified formatting information
        /// </summary>
        public static ulong ToUInt64(object value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, ValueConverter.ToUInt64);
        }
    }
}
