using System;
using System.Data.Common;
using System.IO;

namespace Sorschia.Data
{
    /// <summary>
    /// Contains extension methods for <see cref="DbParameterCollection"/>
    /// </summary>
    public static class DbParameterCollectionExtension
    {
        /// <summary>
        /// Validates the parameters and the parameter name specified.
        /// </summary>
        /// <param name="parameters"></param>
        /// <param name="name"></param>
        private static void Validate(DbParameterCollection parameters, string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("parameter name is set to null or white space.", nameof(name));
            }

            if (parameters.Count <= 0)
            {
                throw new ArgumentException("parameters is empty.", nameof(parameters));
            }
        }

        /// <summary>
        /// Base-getter that requires the parameter name and a function that converts the value.
        /// </summary>
        private static T Get<T>(this DbParameterCollection instance, string name, Func<object, T> convert)
        {
            Validate(instance, name);
            return convert(instance[name]?.Value);
        }

        /// <summary>
        /// Base-getter that requires the parameter name, a formatting information and a function that converts the value using the specified formatting information.
        /// </summary>
        private static T Get<T>(this DbParameterCollection instance, string name, IFormatProvider formatProvider, Func<object, IFormatProvider, T> convert)
        {
            Validate(instance, name);
            return convert(instance[name]?.Value, formatProvider);
        }

        /// <summary>
        /// Gets the value of the specified parameter and converts to <see cref="bool"/>
        /// </summary>
        public static bool GetBoolean(this DbParameterCollection instance, string name)
        {
            return instance.Get(name, DbValueConverter.ToBoolean);
        }

        /// <summary>
        /// Gets the value of the specified parameter and converts to <see cref="bool"/> using the specified formatting information
        /// </summary>
        public static bool GetBoolean(this DbParameterCollection instance, string name, IFormatProvider formatProvider)
        {
            return instance.Get(name, formatProvider, DbValueConverter.ToBoolean);
        }

        /// <summary>
        /// Gets the value of the specified parameter and converts to <see cref="byte"/>
        /// </summary>
        public static byte GetByte(this DbParameterCollection instance, string name)
        {
            return instance.Get(name, DbValueConverter.ToByte);
        }

        /// <summary>
        /// Gets the value of the specified parameter and converts to <see cref="byte"/> using the specified formatting information
        /// </summary>
        public static byte GetByte(this DbParameterCollection instance, string name, IFormatProvider formatProvider)
        {
            return instance.Get(name, formatProvider, DbValueConverter.ToByte);
        }

        /// <summary>
        /// Gets the value of the specified parameter and converts to <see cref="byte[]"/>
        /// </summary>
        public static byte[] GetByteArray(this DbParameterCollection instance, string name)
        {
            return instance.Get(name, DbValueConverter.ToByteArray);
        }

        /// <summary>
        /// Gets the value of the specified parameter and converts to <see cref="char"/>
        /// </summary>
        public static char GetChar(this DbParameterCollection instance, string name)
        {
            return instance.Get(name, DbValueConverter.ToChar);
        }

        /// <summary>
        /// Gets the value of the specified parameter and converts to <see cref="char"/> using the specified formatting information
        /// </summary>
        public static char GetChar(this DbParameterCollection instance, string name, IFormatProvider formatProvider)
        {
            return instance.Get(name, formatProvider, DbValueConverter.ToChar);
        }

        /// <summary>
        /// Gets the value of the specified parameter and converts to <see cref="DateTime"/>
        /// </summary>
        public static DateTime GetDateTime(this DbParameterCollection instance, string name)
        {
            return instance.Get(name, DbValueConverter.ToDateTime);
        }

        /// <summary>
        /// Gets the value of the specified parameter and converts to <see cref="DateTime"/> using the specified formatting information
        /// </summary>
        public static DateTime GetDateTime(this DbParameterCollection instance, string name, IFormatProvider formatProvider)
        {
            return instance.Get(name, formatProvider, DbValueConverter.ToDateTime);
        }

        /// <summary>
        /// Gets the value of the specified parameter and converts to <see cref="decimal"/>
        /// </summary>
        public static decimal GetDecimal(this DbParameterCollection instance, string name)
        {
            return instance.Get(name, DbValueConverter.ToDecimal);
        }

        /// <summary>
        /// Gets the value of the specified parameter and converts to <see cref="decimal"/> using the specified formatting information
        /// </summary>
        public static decimal GetDecimal(this DbParameterCollection instance, string name, IFormatProvider formatProvider)
        {
            return instance.Get(name, formatProvider, DbValueConverter.ToDecimal);
        }

        /// <summary>
        /// Gets the value of the specified parameter and converts to <see cref="double"/>
        /// </summary>
        public static double GetDouble(this DbParameterCollection instance, string name)
        {
            return instance.Get(name, DbValueConverter.ToDouble);
        }

        /// <summary>
        /// Gets the value of the specified parameter and converts to <see cref="double"/> using the specified formatting information
        /// </summary>
        public static double GetDouble(this DbParameterCollection instance, string name, IFormatProvider formatProvider)
        {
            return instance.Get(name, formatProvider, DbValueConverter.ToDouble);
        }

        /// <summary>
        /// Gets the value of the specified parameter and converts to <see cref="short"/>
        /// </summary>
        public static short GetInt16(this DbParameterCollection instance, string name)
        {
            return instance.Get(name, DbValueConverter.ToInt16);
        }

        /// <summary>
        /// Gets the value of the specified parameter and converts to <see cref="short"/> using the specified formatting information
        /// </summary>
        public static short GetInt16(this DbParameterCollection instance, string name, IFormatProvider formatProvider)
        {
            return instance.Get(name, formatProvider, DbValueConverter.ToInt16);
        }

        /// <summary>
        /// Gets the value of the specified parameter and converts to <see cref="int"/>
        /// </summary>
        public static int GetInt32(this DbParameterCollection instance, string name)
        {
            return instance.Get(name, DbValueConverter.ToInt32);
        }

        /// <summary>
        /// Gets the value of the specified parameter and converts to <see cref="int"/> using the specified formatting information
        /// </summary>
        public static int GetInt32(this DbParameterCollection instance, string name, IFormatProvider formatProvider)
        {
            return instance.Get(name, formatProvider, DbValueConverter.ToInt32);
        }

        /// <summary>
        /// Gets the value of the specified parameter and converts to <see cref="long"/>
        /// </summary>
        public static long GetInt64(this DbParameterCollection instance, string name)
        {
            return instance.Get(name, DbValueConverter.ToInt64);
        }

        /// <summary>
        /// Gets the value of the specified parameter and converts to <see cref="long"/> using the specified formatting information
        /// </summary>
        public static long GetInt64(this DbParameterCollection instance, string name, IFormatProvider formatProvider)
        {
            return instance.Get(name, formatProvider, DbValueConverter.ToInt64);
        }

        /// <summary>
        /// Gets the value of the specified parameter and converts to <see cref="bool?"/>
        /// </summary>
        public static bool? GetNullableBoolean(this DbParameterCollection instance, string name)
        {
            return instance.Get(name, DbValueConverter.ToNullableBoolean);
        }

        /// <summary>
        /// Gets the value of the specified parameter and converts to <see cref="bool?"/> using the specified formatting information
        /// </summary>
        public static bool? GetNullableBoolean(this DbParameterCollection instance, string name, IFormatProvider formatProvider)
        {
            return instance.Get(name, formatProvider, DbValueConverter.ToNullableBoolean);
        }

        /// <summary>
        /// Gets the value of the specified parameter and converts to <see cref="byte?"/>
        /// </summary>
        public static byte? GetNullableByte(this DbParameterCollection instance, string name)
        {
            return instance.Get(name, DbValueConverter.ToNullableByte);
        }

        /// <summary>
        /// Gets the value of the specified parameter and converts to <see cref="byte?"/> using the specified formatting information
        /// </summary>
        public static byte? GetNullableByte(this DbParameterCollection instance, string name, IFormatProvider formatProvider)
        {
            return instance.Get(name, formatProvider, DbValueConverter.ToNullableByte);
        }

        /// <summary>
        /// Gets the value of the specified parameter and converts to <see cref="char?"/>
        /// </summary>
        public static char? GetNullableChar(this DbParameterCollection instance, string name)
        {
            return instance.Get(name, DbValueConverter.ToNullableChar);
        }

        /// <summary>
        /// Gets the value of the specified parameter and converts to <see cref="char?"/> using the specified formatting information
        /// </summary>
        public static char? GetNullableChar(this DbParameterCollection instance, string name, IFormatProvider formatProvider)
        {
            return instance.Get(name, formatProvider, DbValueConverter.ToNullableChar);
        }

        /// <summary>
        /// Gets the value of the specified parameter and converts to <see cref="DateTime?"/>
        /// </summary>
        public static DateTime? GetNullableDateTime(this DbParameterCollection instance, string name)
        {
            return instance.Get(name, DbValueConverter.ToNullableDateTime);
        }

        /// <summary>
        /// Gets the value of the specified parameter and converts to <see cref="DateTime?"/> using the specified formatting information
        /// </summary>
        public static DateTime? GetNullableDateTime(this DbParameterCollection instance, string name, IFormatProvider formatProvider)
        {
            return instance.Get(name, formatProvider, DbValueConverter.ToNullableDateTime);
        }

        /// <summary>
        /// Gets the value of the specified parameter and converts to <see cref="decimal?"/>
        /// </summary>
        public static decimal? GetNullableDecimal(this DbParameterCollection instance, string name)
        {
            return instance.Get(name, DbValueConverter.ToNullableDecimal);
        }

        /// <summary>
        /// Gets the value of the specified parameter and converts to <see cref="decimal?"/> using the specified formatting information
        /// </summary>
        public static decimal? GetNullableDecimal(this DbParameterCollection instance, string name, IFormatProvider formatProvider)
        {
            return instance.Get(name, formatProvider, DbValueConverter.ToNullableDecimal);
        }

        /// <summary>
        /// Gets the value of the specified parameter and converts to <see cref="double?"/>
        /// </summary>
        public static double? GetNullableDouble(this DbParameterCollection instance, string name)
        {
            return instance.Get(name, DbValueConverter.ToNullableDouble);
        }

        /// <summary>
        /// Gets the value of the specified parameter and converts to <see cref="double?"/> using the specified formatting information
        /// </summary>
        public static double? GetNullableDouble(this DbParameterCollection instance, string name, IFormatProvider formatProvider)
        {
            return instance.Get(name, formatProvider, DbValueConverter.ToNullableDouble);
        }

        /// <summary>
        /// Gets the value of the specified parameter and converts to <see cref="short?"/>
        /// </summary>
        public static short? GetNullableInt16(this DbParameterCollection instance, string name)
        {
            return instance.Get(name, DbValueConverter.ToNullableInt16);
        }

        /// <summary>
        /// Gets the value of the specified parameter and converts to <see cref="short?"/> using the specified formatting information
        /// </summary>
        public static short? GetNullableInt16(this DbParameterCollection instance, string name, IFormatProvider formatProvider)
        {
            return instance.Get(name, formatProvider, DbValueConverter.ToNullableInt16);
        }

        /// <summary>
        /// Gets the value of the specified parameter and converts to <see cref="int?"/>
        /// </summary>
        public static int? GetNullableInt32(this DbParameterCollection instance, string name)
        {
            return instance.Get(name, DbValueConverter.ToNullableInt32);
        }

        /// <summary>
        /// Gets the value of the specified parameter and converts to <see cref="int?"/> using the specified formatting information
        /// </summary>
        public static int? GetNullableInt32(this DbParameterCollection instance, string name, IFormatProvider formatProvider)
        {
            return instance.Get(name, formatProvider, DbValueConverter.ToNullableInt32);
        }

        /// <summary>
        /// Gets the value of the specified parameter and converts to <see cref="long?"/>
        /// </summary>
        public static long? GetNullableInt64(this DbParameterCollection instance, string name)
        {
            return instance.Get(name, DbValueConverter.ToNullableInt64);
        }

        /// <summary>
        /// Gets the value of the specified parameter and converts to <see cref="long?"/> using the specified formatting information
        /// </summary>
        public static long? GetNullableInt64(this DbParameterCollection instance, string name, IFormatProvider formatProvider)
        {
            return instance.Get(name, formatProvider, DbValueConverter.ToNullableInt64);
        }

        /// <summary>
        /// Gets the value of the specified parameter and converts to <see cref="sbyte?"/>
        /// </summary>
        public static sbyte? GetNullableSByte(this DbParameterCollection instance, string name)
        {
            return instance.Get(name, DbValueConverter.ToNullableSByte);
        }

        /// <summary>
        /// Gets the value of the specified parameter and converts to <see cref="sbyte?"/> using the specified formatting information
        /// </summary>
        public static sbyte? GetNullableSByte(this DbParameterCollection instance, string name, IFormatProvider formatProvider)
        {
            return instance.Get(name, formatProvider, DbValueConverter.ToNullableSByte);
        }

        /// <summary>
        /// Gets the value of the specified parameter and converts to <see cref="float?"/>
        /// </summary>
        public static float? GetNullableSingle(this DbParameterCollection instance, string name)
        {
            return instance.Get(name, DbValueConverter.ToNullableSingle);
        }

        /// <summary>
        /// Gets the value of the specified parameter and converts to <see cref="float?"/> using the specified formatting information
        /// </summary>
        public static float? GetNullableSingle(this DbParameterCollection instance, string name, IFormatProvider formatProvider)
        {
            return instance.Get(name, formatProvider, DbValueConverter.ToNullableSingle);
        }

        /// <summary>
        /// Gets the value of the specified parameter and converts to <see cref="TimeSpan?"/>
        /// </summary>
        public static TimeSpan? GetNullableTimeSpan(this DbParameterCollection instance, string name)
        {
            return instance.Get(name, DbValueConverter.ToNullableTimeSpan);
        }

        /// <summary>
        /// Gets the value of the specified parameter and converts to <see cref="ushort?"/>
        /// </summary>
        public static ushort? GetNullableUInt16(this DbParameterCollection instance, string name)
        {
            return instance.Get(name, DbValueConverter.ToNullableUInt16);
        }

        /// <summary>
        /// Gets the value of the specified parameter and converts to <see cref="ushort?"/> using the specified formatting information
        /// </summary>
        public static ushort? GetNullableUInt16(this DbParameterCollection instance, string name, IFormatProvider formatProvider)
        {
            return instance.Get(name, formatProvider, DbValueConverter.ToNullableUInt16);
        }

        /// <summary>
        /// Gets the value of the specified parameter and converts to <see cref="uint?"/>
        /// </summary>
        public static uint? GetNullableUInt32(this DbParameterCollection instance, string name)
        {
            return instance.Get(name, DbValueConverter.ToNullableUInt32);
        }

        /// <summary>
        /// Gets the value of the specified parameter and converts to <see cref="uint?"/> using the specified formatting information
        /// </summary>
        public static uint? GetNullableUInt32(this DbParameterCollection instance, string name, IFormatProvider formatProvider)
        {
            return instance.Get(name, formatProvider, DbValueConverter.ToNullableUInt32);
        }

        /// <summary>
        /// Gets the value of the specified parameter and converts to <see cref="ulong?"/>
        /// </summary>
        public static ulong? GetNullableUInt64(this DbParameterCollection instance, string name)
        {
            return instance.Get(name, DbValueConverter.ToNullableUInt64);
        }

        /// <summary>
        /// Gets the value of the specified parameter and converts to <see cref="ulong?"/> using the specified formatting information
        /// </summary>
        public static ulong? GetNullableUInt64(this DbParameterCollection instance, string name, IFormatProvider formatProvider)
        {
            return instance.Get(name, formatProvider, DbValueConverter.ToNullableUInt64);
        }

        /// <summary>
        /// Gets the value of the specified parameter and converts to <see cref="sbyte"/>
        /// </summary>
        public static sbyte GetSByte(this DbParameterCollection instance, string name)
        {
            return instance.Get(name, DbValueConverter.ToSByte);
        }

        /// <summary>
        /// Gets the value of the specified parameter and converts to <see cref="sbyte"/> using the specified formatting information
        /// </summary>
        public static sbyte GetSByte(this DbParameterCollection instance, string name, IFormatProvider formatProvider)
        {
            return instance.Get(name, formatProvider, DbValueConverter.ToSByte);
        }

        /// <summary>
        /// Gets the value of the specified parameter and converts to <see cref="float"/>
        /// </summary>
        public static float GetSingle(this DbParameterCollection instance, string name)
        {
            return instance.Get(name, DbValueConverter.ToSingle);
        }

        /// <summary>
        /// Gets the value of the specified parameter and converts to <see cref="float"/> using the specified formatting information
        /// </summary>
        public static float GetSingle(this DbParameterCollection instance, string name, IFormatProvider formatProvider)
        {
            return instance.Get(name, formatProvider, DbValueConverter.ToSingle);
        }

        /// <summary>
        /// Gets the value of the specified parameter and converts to <see cref="Stream"/>
        /// </summary>
        public static Stream GetStream(this DbParameterCollection instance, string name)
        {
            return instance.Get(name, DbValueConverter.ToStream);
        }

        /// <summary>
        /// Gets the value of the specified parameter and converts to <see cref="string"/>
        /// </summary>
        public static string GetString(this DbParameterCollection instance, string name)
        {
            return instance.Get(name, DbValueConverter.ToString);
        }

        /// <summary>
        /// Gets the value of the specified parameter and converts to <see cref="string"/> using the specified formatting information
        /// </summary>
        public static string GetString(this DbParameterCollection instance, string name, IFormatProvider formatProvider)
        {
            return instance.Get(name, formatProvider, DbValueConverter.ToString);
        }

        /// <summary>
        /// Gets the value of the specified parameter and converts to <see cref="TimeSpan"/>
        /// </summary>
        public static TimeSpan GetTimeSpan(this DbParameterCollection instance, string name)
        {
            return instance.Get(name, DbValueConverter.ToTimeSpan);
        }

        /// <summary>
        /// Gets the value of the specified parameter and converts to <see cref="ushort"/>
        /// </summary>
        public static ushort GetUInt16(this DbParameterCollection instance, string name)
        {
            return instance.Get(name, DbValueConverter.ToUInt16);
        }

        /// <summary>
        /// Gets the value of the specified parameter and converts to <see cref="ushort"/> using the specified formatting information
        /// </summary>
        public static ushort GetUInt16(this DbParameterCollection instance, string name, IFormatProvider formatProvider)
        {
            return instance.Get(name, formatProvider, DbValueConverter.ToUInt16);
        }

        /// <summary>
        /// Gets the value of the specified parameter and converts to <see cref="uint"/>
        /// </summary>
        public static uint GetUInt32(this DbParameterCollection instance, string name)
        {
            return instance.Get(name, DbValueConverter.ToUInt32);
        }

        /// <summary>
        /// Gets the value of the specified parameter and converts to <see cref="uint"/> using the specified formatting information
        /// </summary>
        public static uint GetUInt32(this DbParameterCollection instance, string name, IFormatProvider formatProvider)
        {
            return instance.Get(name, formatProvider, DbValueConverter.ToUInt32);
        }

        /// <summary>
        /// Gets the value of the specified parameter and converts to <see cref="ulong"/>
        /// </summary>
        public static ulong GetUInt64(this DbParameterCollection instance, string name)
        {
            return instance.Get(name, DbValueConverter.ToUInt64);
        }

        /// <summary>
        /// Gets the value of the specified parameter and converts to <see cref="ulong"/> using the specified formatting information
        /// </summary>
        public static ulong GetUInt64(this DbParameterCollection instance, string name, IFormatProvider formatProvider)
        {
            return instance.Get(name, formatProvider, DbValueConverter.ToUInt64);
        }
    }
}
