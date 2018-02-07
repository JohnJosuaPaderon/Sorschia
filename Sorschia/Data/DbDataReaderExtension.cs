using System;
using System.Data.Common;
using System.IO;

namespace Sorschia.Data
{
    /// <summary>
    /// Contains extension methods for <see cref="DbDataReader"/>
    /// </summary>
    public static class DbDataReaderExtension
    {
        /// <summary>
        /// Validates the reader and the field's name specified.
        /// </summary>
        private static void Validate(DbDataReader reader, string fieldName)
        {
            if (string.IsNullOrWhiteSpace(fieldName))
            {
                throw new ArgumentException("fieldname is set to null or white space.", nameof(fieldName));
            }

            if (reader == null)
            {
                throw new ArgumentNullException(nameof(reader));
            }

            if (reader.FieldCount <= 0)
            {
                throw new ArgumentException("reader has not fields.", nameof(reader));
            }
        }

        /// <summary>
        /// Base-getter that requires the field's name and a function that converts the value.
        /// </summary>
        private static T Get<T>(this DbDataReader instance, string fieldName, Func<object, T> convert)
        {
            Validate(instance, fieldName);
            return convert(instance[fieldName]);
        }

        /// <summary>
        /// Base-getter that requires the field's name, a formatting information and a function that converts the value using the specified formatting information.
        /// </summary>
        private static T Get<T>(this DbDataReader instance, string fieldName, IFormatProvider formatProvider, Func<object, IFormatProvider, T> convert)
        {
            Validate(instance, fieldName);
            return convert(instance[fieldName], formatProvider);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="bool"/>
        /// </summary>
        public static bool GetBoolean(this DbDataReader instance, string fieldName)
        {
            return instance.Get(fieldName, DbValueConverter.ToBoolean);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="bool"/> using the specified formatting information
        /// </summary>
        public static bool GetBoolean(this DbDataReader instance, string fieldName, IFormatProvider formatProvider)
        {
            return instance.Get(fieldName, formatProvider, DbValueConverter.ToBoolean);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="byte"/>
        /// </summary>
        public static byte GetByte(this DbDataReader instance, string fieldName)
        {
            return instance.Get(fieldName, DbValueConverter.ToByte);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="byte"/> using the specified formatting information
        /// </summary>
        public static byte GetByte(this DbDataReader instance, string fieldName, IFormatProvider formatProvider)
        {
            return instance.Get(fieldName, formatProvider, DbValueConverter.ToByte);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="byte[]"/>
        /// </summary>
        public static byte[] GetByteArray(this DbDataReader instance, string fieldName)
        {
            return instance.Get(fieldName, DbValueConverter.ToByteArray);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="char"/>
        /// </summary>
        public static char GetChar(this DbDataReader instance, string fieldName)
        {
            return instance.Get(fieldName, DbValueConverter.ToChar);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="char"/> using the specified formatting information
        /// </summary>
        public static char GetChar(this DbDataReader instance, string fieldName, IFormatProvider formatProvider)
        {
            return instance.Get(fieldName, formatProvider, DbValueConverter.ToChar);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="DateTime"/>
        /// </summary>
        public static DateTime GetDateTime(this DbDataReader instance, string fieldName)
        {
            return instance.Get(fieldName, DbValueConverter.ToDateTime);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="DateTime"/> using the specified formatting information
        /// </summary>
        public static DateTime GetDateTime(this DbDataReader instance, string fieldName, IFormatProvider formatProvider)
        {
            return instance.Get(fieldName, formatProvider, DbValueConverter.ToDateTime);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="decimal"/>
        /// </summary>
        public static decimal GetDecimal(this DbDataReader instance, string fieldName)
        {
            return instance.Get(fieldName, DbValueConverter.ToDecimal);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="decimal"/> using the specified formatting information
        /// </summary>
        public static decimal GetDecimal(this DbDataReader instance, string fieldName, IFormatProvider formatProvider)
        {
            return instance.Get(fieldName, formatProvider, DbValueConverter.ToDecimal);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="double"/>
        /// </summary>
        public static double GetDouble(this DbDataReader instance, string fieldName)
        {
            return instance.Get(fieldName, DbValueConverter.ToDouble);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="double"/> using the specified formatting information
        /// </summary>
        public static double GetDouble(this DbDataReader instance, string fieldName, IFormatProvider formatProvider)
        {
            return instance.Get(fieldName, formatProvider, DbValueConverter.ToDouble);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="short"/>
        /// </summary>
        public static short GetInt16(this DbDataReader instance, string fieldName)
        {
            return instance.Get(fieldName, DbValueConverter.ToInt16);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="short"/> using the specified formatting information
        /// </summary>
        public static short GetInt16(this DbDataReader instance, string fieldName, IFormatProvider formatProvider)
        {
            return instance.Get(fieldName, formatProvider, DbValueConverter.ToInt16);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="int"/>
        /// </summary>
        public static int GetInt32(this DbDataReader instance, string fieldName)
        {
            return instance.Get(fieldName, DbValueConverter.ToInt32);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="int"/> using the specified formatting information
        /// </summary>
        public static int GetInt32(this DbDataReader instance, string fieldName, IFormatProvider formatProvider)
        {
            return instance.Get(fieldName, formatProvider, DbValueConverter.ToInt32);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="long"/>
        /// </summary>
        public static long GetInt64(this DbDataReader instance, string fieldName)
        {
            return instance.Get(fieldName, DbValueConverter.ToInt64);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="long"/> using the specified formatting information
        /// </summary>
        public static long GetInt64(this DbDataReader instance, string fieldName, IFormatProvider formatProvider)
        {
            return instance.Get(fieldName, formatProvider, DbValueConverter.ToInt64);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="bool?"/>
        /// </summary>
        public static bool? GetNullableBoolean(this DbDataReader instance, string fieldName)
        {
            return instance.Get(fieldName, DbValueConverter.ToNullableBoolean);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="bool?"/> using the specified formatting information
        /// </summary>
        public static bool? GetNullableBoolean(this DbDataReader instance, string fieldName, IFormatProvider formatProvider)
        {
            return instance.Get(fieldName, formatProvider, DbValueConverter.ToNullableBoolean);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="byte?"/>
        /// </summary>
        public static byte? GetNullableByte(this DbDataReader instance, string fieldName)
        {
            return instance.Get(fieldName, DbValueConverter.ToNullableByte);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="byte?"/> using the specified formatting information
        /// </summary>
        public static byte? GetNullableByte(this DbDataReader instance, string fieldName, IFormatProvider formatProvider)
        {
            return instance.Get(fieldName, formatProvider, DbValueConverter.ToNullableByte);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="char?"/>
        /// </summary>
        public static char? GetNullableChar(this DbDataReader instance, string fieldName)
        {
            return instance.Get(fieldName, DbValueConverter.ToNullableChar);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="char?"/> using the specified formatting information
        /// </summary>
        public static char? GetNullableChar(this DbDataReader instance, string fieldName, IFormatProvider formatProvider)
        {
            return instance.Get(fieldName, formatProvider, DbValueConverter.ToNullableChar);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="DateTime?"/>
        /// </summary>
        public static DateTime? GetNullableDateTime(this DbDataReader instance, string fieldName)
        {
            return instance.Get(fieldName, DbValueConverter.ToNullableDateTime);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="DateTime?"/> using the specified formatting information
        /// </summary>
        public static DateTime? GetNullableDateTime(this DbDataReader instance, string fieldName, IFormatProvider formatProvider)
        {
            return instance.Get(fieldName, formatProvider, DbValueConverter.ToNullableDateTime);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="decimal?"/>
        /// </summary>
        public static decimal? GetNullableDecimal(this DbDataReader instance, string fieldName)
        {
            return instance.Get(fieldName, DbValueConverter.ToNullableDecimal);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="decimal?"/> using the specified formatting information
        /// </summary>
        public static decimal? GetNullableDecimal(this DbDataReader instance, string fieldName, IFormatProvider formatProvider)
        {
            return instance.Get(fieldName, formatProvider, DbValueConverter.ToNullableDecimal);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="double?"/>
        /// </summary>
        public static double? GetNullableDouble(this DbDataReader instance, string fieldName)
        {
            return instance.Get(fieldName, DbValueConverter.ToNullableDouble);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="double?"/> using the specified formatting information
        /// </summary>
        public static double? GetNullableDouble(this DbDataReader instance, string fieldName, IFormatProvider formatProvider)
        {
            return instance.Get(fieldName, formatProvider, DbValueConverter.ToNullableDouble);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="short?"/>
        /// </summary>
        public static short? GetNullableInt16(this DbDataReader instance, string fieldName)
        {
            return instance.Get(fieldName, DbValueConverter.ToNullableInt16);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="short?"/> using the specified formatting information
        /// </summary>
        public static short? GetNullableInt16(this DbDataReader instance, string fieldName, IFormatProvider formatProvider)
        {
            return instance.Get(fieldName, formatProvider, DbValueConverter.ToNullableInt16);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="int?"/>
        /// </summary>
        public static int? GetNullableInt32(this DbDataReader instance, string fieldName)
        {
            return instance.Get(fieldName, DbValueConverter.ToNullableInt32);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="int?"/> using the specified formatting information
        /// </summary>
        public static int? GetNullableInt32(this DbDataReader instance, string fieldName, IFormatProvider formatProvider)
        {
            return instance.Get(fieldName, formatProvider, DbValueConverter.ToNullableInt32);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="long?"/>
        /// </summary>
        public static long? GetNullableInt64(this DbDataReader instance, string fieldName)
        {
            return instance.Get(fieldName, DbValueConverter.ToNullableInt64);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="long?"/> using the specified formatting information
        /// </summary>
        public static long? GetNullableInt64(this DbDataReader instance, string fieldName, IFormatProvider formatProvider)
        {
            return instance.Get(fieldName, formatProvider, DbValueConverter.ToNullableInt64);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="sbyte?"/>
        /// </summary>
        public static sbyte? GetNullableSByte(this DbDataReader instance, string fieldName)
        {
            return instance.Get(fieldName, DbValueConverter.ToNullableSByte);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="sbyte?"/> using the specified formatting information
        /// </summary>
        public static sbyte? GetNullableSByte(this DbDataReader instance, string fieldName, IFormatProvider formatProvider)
        {
            return instance.Get(fieldName, formatProvider, DbValueConverter.ToNullableSByte);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="float?"/>
        /// </summary>
        public static float? GetNullableSingle(this DbDataReader instance, string fieldName)
        {
            return instance.Get(fieldName, DbValueConverter.ToNullableSingle);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="float?"/> using the specified formatting information
        /// </summary>
        public static float? GetNullableSingle(this DbDataReader instance, string fieldName, IFormatProvider formatProvider)
        {
            return instance.Get(fieldName, formatProvider, DbValueConverter.ToNullableSingle);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="TimeSpan?"/>
        /// </summary>
        public static TimeSpan? GetNullableTimeSpan(this DbDataReader instance, string fieldName)
        {
            return instance.Get(fieldName, DbValueConverter.ToNullableTimeSpan);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="ushort?"/>
        /// </summary>
        public static ushort? GetNullableUInt16(this DbDataReader instance, string fieldName)
        {
            return instance.Get(fieldName, DbValueConverter.ToNullableUInt16);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="ushort?"/> using the specified formatting information
        /// </summary>
        public static ushort? GetNullableUInt16(this DbDataReader instance, string fieldName, IFormatProvider formatProvider)
        {
            return instance.Get(fieldName, formatProvider, DbValueConverter.ToNullableUInt16);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="uint?"/>
        /// </summary>
        public static uint? GetNullableUInt32(this DbDataReader instance, string fieldName)
        {
            return instance.Get(fieldName, DbValueConverter.ToNullableUInt32);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="uint?"/> using the specified formatting information
        /// </summary>
        public static uint? GetNullableUInt32(this DbDataReader instance, string fieldName, IFormatProvider formatProvider)
        {
            return instance.Get(fieldName, formatProvider, DbValueConverter.ToNullableUInt32);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="ulong?"/>
        /// </summary>
        public static ulong? GetNullableUInt64(this DbDataReader instance, string fieldName)
        {
            return instance.Get(fieldName, DbValueConverter.ToNullableUInt64);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="ulong?"/> using the specified formatting information
        /// </summary>
        public static ulong? GetNullableUInt64(this DbDataReader instance, string fieldName, IFormatProvider formatProvider)
        {
            return instance.Get(fieldName, formatProvider, DbValueConverter.ToNullableUInt64);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="sbyte"/>
        /// </summary>
        public static sbyte GetSByte(this DbDataReader instance, string fieldName)
        {
            return instance.Get(fieldName, DbValueConverter.ToSByte);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="sbyte"/> using the specified formatting information
        /// </summary>
        public static sbyte GetSByte(this DbDataReader instance, string fieldName, IFormatProvider formatProvider)
        {
            return instance.Get(fieldName, formatProvider, DbValueConverter.ToSByte);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="float"/>
        /// </summary>
        public static float GetSingle(this DbDataReader instance, string fieldName)
        {
            return instance.Get(fieldName, DbValueConverter.ToSingle);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="float"/> using the specified formatting information
        /// </summary>
        public static float GetSingle(this DbDataReader instance, string fieldName, IFormatProvider formatProvider)
        {
            return instance.Get(fieldName, formatProvider, DbValueConverter.ToSingle);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="Stream"/>
        /// </summary>
        public static Stream GetStream(this DbDataReader instance, string fieldName)
        {
            return instance.Get(fieldName, DbValueConverter.ToStream);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="string"/>
        /// </summary>
        public static string GetString(this DbDataReader instance, string fieldName)
        {
            return instance.Get(fieldName, DbValueConverter.ToString);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="string"/> using the specified formatting information
        /// </summary>
        public static string GetString(this DbDataReader instance, string fieldName, IFormatProvider formatProvider)
        {
            return instance.Get(fieldName, formatProvider, DbValueConverter.ToString);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="TimeSpan"/>
        /// </summary>
        public static TimeSpan GetTimeSpan(this DbDataReader instance, string fieldName)
        {
            return instance.Get(fieldName, DbValueConverter.ToTimeSpan);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="ushort"/>
        /// </summary>
        public static ushort GetUInt16(this DbDataReader instance, string fieldName)
        {
            return instance.Get(fieldName, DbValueConverter.ToUInt16);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="ushort"/> using the specified formatting information
        /// </summary>
        public static ushort GetUInt16(this DbDataReader instance, string fieldName, IFormatProvider formatProvider)
        {
            return instance.Get(fieldName, formatProvider, DbValueConverter.ToUInt16);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="uint"/>
        /// </summary>
        public static uint GetUInt32(this DbDataReader instance, string fieldName)
        {
            return instance.Get(fieldName, DbValueConverter.ToUInt32);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="uint"/> using the specified formatting information
        /// </summary>
        public static uint GetUInt32(this DbDataReader instance, string fieldName, IFormatProvider formatProvider)
        {
            return instance.Get(fieldName, formatProvider, DbValueConverter.ToUInt32);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="ulong"/>
        /// </summary>
        public static ulong GetUInt64(this DbDataReader instance, string fieldName)
        {
            return instance.Get(fieldName, DbValueConverter.ToUInt64);
        }

        /// <summary>
        /// Gets the value of the specified field and converts to <see cref="ulong"/> using the specified formatting information
        /// </summary>
        public static ulong GetUInt64(this DbDataReader instance, string fieldName, IFormatProvider formatProvider)
        {
            return instance.Get(fieldName, formatProvider, DbValueConverter.ToUInt64);
        }
    }
}
