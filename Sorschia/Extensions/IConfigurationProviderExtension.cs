using Sorschia.Configuration;
using Sorschia.Security;
using Sorschia.Utilities;
using System;
using System.IO;
using System.Security;

namespace Sorschia
{
    public static class IConfigurationProviderExtension
    {
        private static T Get<T>(this IConfigurationProvider instance, string key, Func<object, T> convert)
        {
            var value = instance[key];

            return value != null ? convert(value) : default(T);
        }

        private static T Get<T>(this IConfigurationProvider instance, string key, IFormatProvider formatProvider, Func<object, IFormatProvider, T> convert)
        {
            var value = instance[key];
            return value != null ? convert(value, formatProvider) : default(T);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="bool"/>
        /// </summary>
        public static bool GetBoolean(this IConfigurationProvider instance, string fieldName)
        {
            return instance.Get(fieldName, ValueConverter.ToBoolean);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="bool"/> using the specified formatting information
        /// </summary>
        public static bool GetBoolean(this IConfigurationProvider instance, string fieldName, IFormatProvider formatProvider)
        {
            return instance.Get(fieldName, formatProvider, ValueConverter.ToBoolean);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="byte"/>
        /// </summary>
        public static byte GetByte(this IConfigurationProvider instance, string fieldName)
        {
            return instance.Get(fieldName, ValueConverter.ToByte);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="byte"/> using the specified formatting information
        /// </summary>
        public static byte GetByte(this IConfigurationProvider instance, string fieldName, IFormatProvider formatProvider)
        {
            return instance.Get(fieldName, formatProvider, ValueConverter.ToByte);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="byte[]"/>
        /// </summary>
        public static byte[] GetByteArray(this IConfigurationProvider instance, string fieldName)
        {
            return instance.Get(fieldName, ValueConverter.ToByteArray);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="char"/>
        /// </summary>
        public static char GetChar(this IConfigurationProvider instance, string fieldName)
        {
            return instance.Get(fieldName, ValueConverter.ToChar);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="char"/> using the specified formatting information
        /// </summary>
        public static char GetChar(this IConfigurationProvider instance, string fieldName, IFormatProvider formatProvider)
        {
            return instance.Get(fieldName, formatProvider, ValueConverter.ToChar);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="DateTime"/>
        /// </summary>
        public static DateTime GetDateTime(this IConfigurationProvider instance, string fieldName)
        {
            return instance.Get(fieldName, ValueConverter.ToDateTime);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="DateTime"/> using the specified formatting information
        /// </summary>
        public static DateTime GetDateTime(this IConfigurationProvider instance, string fieldName, IFormatProvider formatProvider)
        {
            return instance.Get(fieldName, formatProvider, ValueConverter.ToDateTime);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="decimal"/>
        /// </summary>
        public static decimal GetDecimal(this IConfigurationProvider instance, string fieldName)
        {
            return instance.Get(fieldName, ValueConverter.ToDecimal);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="decimal"/> using the specified formatting information
        /// </summary>
        public static decimal GetDecimal(this IConfigurationProvider instance, string fieldName, IFormatProvider formatProvider)
        {
            return instance.Get(fieldName, formatProvider, ValueConverter.ToDecimal);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="double"/>
        /// </summary>
        public static double GetDouble(this IConfigurationProvider instance, string fieldName)
        {
            return instance.Get(fieldName, ValueConverter.ToDouble);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="double"/> using the specified formatting information
        /// </summary>
        public static double GetDouble(this IConfigurationProvider instance, string fieldName, IFormatProvider formatProvider)
        {
            return instance.Get(fieldName, formatProvider, ValueConverter.ToDouble);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="short"/>
        /// </summary>
        public static short GetInt16(this IConfigurationProvider instance, string fieldName)
        {
            return instance.Get(fieldName, ValueConverter.ToInt16);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="short"/> using the specified formatting information
        /// </summary>
        public static short GetInt16(this IConfigurationProvider instance, string fieldName, IFormatProvider formatProvider)
        {
            return instance.Get(fieldName, formatProvider, ValueConverter.ToInt16);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="int"/>
        /// </summary>
        public static int GetInt32(this IConfigurationProvider instance, string fieldName)
        {
            return instance.Get(fieldName, ValueConverter.ToInt32);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="int"/> using the specified formatting information
        /// </summary>
        public static int GetInt32(this IConfigurationProvider instance, string fieldName, IFormatProvider formatProvider)
        {
            return instance.Get(fieldName, formatProvider, ValueConverter.ToInt32);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="long"/>
        /// </summary>
        public static long GetInt64(this IConfigurationProvider instance, string fieldName)
        {
            return instance.Get(fieldName, ValueConverter.ToInt64);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="long"/> using the specified formatting information
        /// </summary>
        public static long GetInt64(this IConfigurationProvider instance, string fieldName, IFormatProvider formatProvider)
        {
            return instance.Get(fieldName, formatProvider, ValueConverter.ToInt64);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="bool?"/>
        /// </summary>
        public static bool? GetNullableBoolean(this IConfigurationProvider instance, string fieldName)
        {
            return instance.Get(fieldName, ValueConverter.ToNullableBoolean);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="bool?"/> using the specified formatting information
        /// </summary>
        public static bool? GetNullableBoolean(this IConfigurationProvider instance, string fieldName, IFormatProvider formatProvider)
        {
            return instance.Get(fieldName, formatProvider, ValueConverter.ToNullableBoolean);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="byte?"/>
        /// </summary>
        public static byte? GetNullableByte(this IConfigurationProvider instance, string fieldName)
        {
            return instance.Get(fieldName, ValueConverter.ToNullableByte);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="byte?"/> using the specified formatting information
        /// </summary>
        public static byte? GetNullableByte(this IConfigurationProvider instance, string fieldName, IFormatProvider formatProvider)
        {
            return instance.Get(fieldName, formatProvider, ValueConverter.ToNullableByte);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="char?"/>
        /// </summary>
        public static char? GetNullableChar(this IConfigurationProvider instance, string fieldName)
        {
            return instance.Get(fieldName, ValueConverter.ToNullableChar);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="char?"/> using the specified formatting information
        /// </summary>
        public static char? GetNullableChar(this IConfigurationProvider instance, string fieldName, IFormatProvider formatProvider)
        {
            return instance.Get(fieldName, formatProvider, ValueConverter.ToNullableChar);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="DateTime?"/>
        /// </summary>
        public static DateTime? GetNullableDateTime(this IConfigurationProvider instance, string fieldName)
        {
            return instance.Get(fieldName, ValueConverter.ToNullableDateTime);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="DateTime?"/> using the specified formatting information
        /// </summary>
        public static DateTime? GetNullableDateTime(this IConfigurationProvider instance, string fieldName, IFormatProvider formatProvider)
        {
            return instance.Get(fieldName, formatProvider, ValueConverter.ToNullableDateTime);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="decimal?"/>
        /// </summary>
        public static decimal? GetNullableDecimal(this IConfigurationProvider instance, string fieldName)
        {
            return instance.Get(fieldName, ValueConverter.ToNullableDecimal);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="decimal?"/> using the specified formatting information
        /// </summary>
        public static decimal? GetNullableDecimal(this IConfigurationProvider instance, string fieldName, IFormatProvider formatProvider)
        {
            return instance.Get(fieldName, formatProvider, ValueConverter.ToNullableDecimal);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="double?"/>
        /// </summary>
        public static double? GetNullableDouble(this IConfigurationProvider instance, string fieldName)
        {
            return instance.Get(fieldName, ValueConverter.ToNullableDouble);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="double?"/> using the specified formatting information
        /// </summary>
        public static double? GetNullableDouble(this IConfigurationProvider instance, string fieldName, IFormatProvider formatProvider)
        {
            return instance.Get(fieldName, formatProvider, ValueConverter.ToNullableDouble);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="short?"/>
        /// </summary>
        public static short? GetNullableInt16(this IConfigurationProvider instance, string fieldName)
        {
            return instance.Get(fieldName, ValueConverter.ToNullableInt16);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="short?"/> using the specified formatting information
        /// </summary>
        public static short? GetNullableInt16(this IConfigurationProvider instance, string fieldName, IFormatProvider formatProvider)
        {
            return instance.Get(fieldName, formatProvider, ValueConverter.ToNullableInt16);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="int?"/>
        /// </summary>
        public static int? GetNullableInt32(this IConfigurationProvider instance, string fieldName)
        {
            return instance.Get(fieldName, ValueConverter.ToNullableInt32);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="int?"/> using the specified formatting information
        /// </summary>
        public static int? GetNullableInt32(this IConfigurationProvider instance, string fieldName, IFormatProvider formatProvider)
        {
            return instance.Get(fieldName, formatProvider, ValueConverter.ToNullableInt32);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="long?"/>
        /// </summary>
        public static long? GetNullableInt64(this IConfigurationProvider instance, string fieldName)
        {
            return instance.Get(fieldName, ValueConverter.ToNullableInt64);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="long?"/> using the specified formatting information
        /// </summary>
        public static long? GetNullableInt64(this IConfigurationProvider instance, string fieldName, IFormatProvider formatProvider)
        {
            return instance.Get(fieldName, formatProvider, ValueConverter.ToNullableInt64);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="sbyte?"/>
        /// </summary>
        public static sbyte? GetNullableSByte(this IConfigurationProvider instance, string fieldName)
        {
            return instance.Get(fieldName, ValueConverter.ToNullableSByte);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="sbyte?"/> using the specified formatting information
        /// </summary>
        public static sbyte? GetNullableSByte(this IConfigurationProvider instance, string fieldName, IFormatProvider formatProvider)
        {
            return instance.Get(fieldName, formatProvider, ValueConverter.ToNullableSByte);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="float?"/>
        /// </summary>
        public static float? GetNullableSingle(this IConfigurationProvider instance, string fieldName)
        {
            return instance.Get(fieldName, ValueConverter.ToNullableSingle);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="float?"/> using the specified formatting information
        /// </summary>
        public static float? GetNullableSingle(this IConfigurationProvider instance, string fieldName, IFormatProvider formatProvider)
        {
            return instance.Get(fieldName, formatProvider, ValueConverter.ToNullableSingle);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="TimeSpan?"/>
        /// </summary>
        public static TimeSpan? GetNullableTimeSpan(this IConfigurationProvider instance, string fieldName)
        {
            return instance.Get(fieldName, ValueConverter.ToNullableTimeSpan);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="ushort?"/>
        /// </summary>
        public static ushort? GetNullableUInt16(this IConfigurationProvider instance, string fieldName)
        {
            return instance.Get(fieldName, ValueConverter.ToNullableUInt16);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="ushort?"/> using the specified formatting information
        /// </summary>
        public static ushort? GetNullableUInt16(this IConfigurationProvider instance, string fieldName, IFormatProvider formatProvider)
        {
            return instance.Get(fieldName, formatProvider, ValueConverter.ToNullableUInt16);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="uint?"/>
        /// </summary>
        public static uint? GetNullableUInt32(this IConfigurationProvider instance, string fieldName)
        {
            return instance.Get(fieldName, ValueConverter.ToNullableUInt32);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="uint?"/> using the specified formatting information
        /// </summary>
        public static uint? GetNullableUInt32(this IConfigurationProvider instance, string fieldName, IFormatProvider formatProvider)
        {
            return instance.Get(fieldName, formatProvider, ValueConverter.ToNullableUInt32);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="ulong?"/>
        /// </summary>
        public static ulong? GetNullableUInt64(this IConfigurationProvider instance, string fieldName)
        {
            return instance.Get(fieldName, ValueConverter.ToNullableUInt64);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="ulong?"/> using the specified formatting information
        /// </summary>
        public static ulong? GetNullableUInt64(this IConfigurationProvider instance, string fieldName, IFormatProvider formatProvider)
        {
            return instance.Get(fieldName, formatProvider, ValueConverter.ToNullableUInt64);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="sbyte"/>
        /// </summary>
        public static sbyte GetSByte(this IConfigurationProvider instance, string fieldName)
        {
            return instance.Get(fieldName, ValueConverter.ToSByte);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="sbyte"/> using the specified formatting information
        /// </summary>
        public static sbyte GetSByte(this IConfigurationProvider instance, string fieldName, IFormatProvider formatProvider)
        {
            return instance.Get(fieldName, formatProvider, ValueConverter.ToSByte);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="SecureString"/>
        /// </summary>
        public static SecureString GetSecureString(this IConfigurationProvider instance, string fieldName)
        {
            return SecureStringConverter.Convert(instance.GetString(fieldName));
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="float"/>
        /// </summary>
        public static float GetSingle(this IConfigurationProvider instance, string fieldName)
        {
            return instance.Get(fieldName, ValueConverter.ToSingle);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="float"/> using the specified formatting information
        /// </summary>
        public static float GetSingle(this IConfigurationProvider instance, string fieldName, IFormatProvider formatProvider)
        {
            return instance.Get(fieldName, formatProvider, ValueConverter.ToSingle);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="Stream"/>
        /// </summary>
        public static Stream GetStream(this IConfigurationProvider instance, string fieldName)
        {
            return instance.Get(fieldName, ValueConverter.ToStream);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="string"/>
        /// </summary>
        public static string GetString(this IConfigurationProvider instance, string fieldName)
        {
            return instance.Get(fieldName, ValueConverter.ToString);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="string"/> using the specified formatting information
        /// </summary>
        public static string GetString(this IConfigurationProvider instance, string fieldName, IFormatProvider formatProvider)
        {
            return instance.Get(fieldName, formatProvider, ValueConverter.ToString);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="TimeSpan"/>
        /// </summary>
        public static TimeSpan GetTimeSpan(this IConfigurationProvider instance, string fieldName)
        {
            return instance.Get(fieldName, ValueConverter.ToTimeSpan);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="ushort"/>
        /// </summary>
        public static ushort GetUInt16(this IConfigurationProvider instance, string fieldName)
        {
            return instance.Get(fieldName, ValueConverter.ToUInt16);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="ushort"/> using the specified formatting information
        /// </summary>
        public static ushort GetUInt16(this IConfigurationProvider instance, string fieldName, IFormatProvider formatProvider)
        {
            return instance.Get(fieldName, formatProvider, ValueConverter.ToUInt16);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="uint"/>
        /// </summary>
        public static uint GetUInt32(this IConfigurationProvider instance, string fieldName)
        {
            return instance.Get(fieldName, ValueConverter.ToUInt32);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="uint"/> using the specified formatting information
        /// </summary>
        public static uint GetUInt32(this IConfigurationProvider instance, string fieldName, IFormatProvider formatProvider)
        {
            return instance.Get(fieldName, formatProvider, ValueConverter.ToUInt32);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="ulong"/>
        /// </summary>
        public static ulong GetUInt64(this IConfigurationProvider instance, string fieldName)
        {
            return instance.Get(fieldName, ValueConverter.ToUInt64);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="ulong"/> using the specified formatting information
        /// </summary>
        public static ulong GetUInt64(this IConfigurationProvider instance, string fieldName, IFormatProvider formatProvider)
        {
            return instance.Get(fieldName, formatProvider, ValueConverter.ToUInt64);
        }

        public static Guid GetGuid(this IConfigurationProvider instance, string fieldName)
        {
            return instance.Get(fieldName, ValueConverter.ToGuid);
        }
    }
}
