using System;

namespace Sorschia
{
    partial class Validator
    {
        public static void GreaterThanByte(byte value, byte maxValue, string message)
        {
            if (value > maxValue)
            {
                throw new ValidationException(message, ValidationType.GreaterThan);
            }
        }

        public static void GreaterThanDateTime(DateTime value, DateTime maxValue, string message)
        {
            if (value > maxValue)
            {
                throw new ValidationException(message, ValidationType.GreaterThan);
            }
        }

        public static void GreaterThanDecimal(decimal value, byte maxValue, string message)
        {
            if (value > maxValue)
            {
                throw new ValidationException(message, ValidationType.GreaterThan);
            }
        }

        public static void GreaterThanDouble(double value, double maxValue, string message)
        {
            if (value > maxValue)
            {
                throw new ValidationException(message, ValidationType.GreaterThan);
            }
        }

        public static void GreaterThanInt16(short value, short maxValue, string message)
        {
            if (value > maxValue)
            {
                throw new ValidationException(message, ValidationType.GreaterThan);
            }
        }

        public static void GreaterThanInt32(int value, int maxValue, string message)
        {
            if (value > maxValue)
            {
                throw new ValidationException(message, ValidationType.GreaterThan);
            }
        }

        public static void GreaterThanInt64(long value, long maxValue, string message)
        {
            if (value > maxValue)
            {
                throw new ValidationException(message, ValidationType.GreaterThan);
            }
        }

        public static void GreaterThanSByte(sbyte value, sbyte maxValue, string message)
        {
            if (value > maxValue)
            {
                throw new ValidationException(message, ValidationType.GreaterThan);
            }
        }

        public static void GreaterThanSingle(float value, float maxValue, string message)
        {
            if (value > maxValue)
            {
                throw new ValidationException(message, ValidationType.GreaterThan);
            }
        }

        public static void GreaterThanTimeSpan(TimeSpan value, TimeSpan maxValue, string message)
        {
            if (value > maxValue)
            {
                throw new ValidationException(message, ValidationType.GreaterThan);
            }
        }

        public static void GreaterThanUInt16(ushort value, ushort maxValue, string message)
        {
            if (value > maxValue)
            {
                throw new ValidationException(message, ValidationType.GreaterThan);
            }
        }

        public static void GreaterThanUInt32(uint value, uint maxValue, string message)
        {
            if (value > maxValue)
            {
                throw new ValidationException(message, ValidationType.GreaterThan);
            }
        }

        public static void GreaterThanUInt64(ulong value, ulong maxValue, string message)
        {
            if (value > maxValue)
            {
                throw new ValidationException(message, ValidationType.GreaterThan);
            }
        }

        public static void GreaterThanByte(byte? value, byte maxValue, string message)
        {
            Null(value, message);
            GreaterThanByte(value.Value, maxValue, message);
        }

        public static void GreaterThanDateTime(DateTime? value, DateTime maxValue, string message)
        {
            Null(value, message);
            GreaterThanDateTime(value.Value, maxValue, message);
        }

        public static void GreaterThanDecimal(decimal? value, decimal maxValue, string message)
        {
            Null(value, message);
            GreaterThanDecimal(value.Value, maxValue, message);
        }

        public static void GreaterThanDouble(double? value, double maxValue, string message)
        {
            Null(value, message);
            GreaterThanDouble(value.Value, maxValue, message);
        }

        public static void GreaterThanInt16(short? value, short maxValue, string message)
        {
            Null(value, message);
            GreaterThanInt16(value.Value, maxValue, message);
        }

        public static void GreaterThanInt32(int? value, int maxValue, string message)
        {
            Null(value, message);
            GreaterThanInt32(value.Value, maxValue, message);
        }

        public static void GreaterThanInt64(long? value, long maxValue, string message)
        {
            Null(value, message);
            GreaterThanInt64(value.Value, maxValue, message);
        }

        public static void GreaterThanSByte(sbyte? value, sbyte maxValue, string message)
        {
            Null(value, message);
            GreaterThanSByte(value.Value, maxValue, message);
        }

        public static void GreaterThanSingle(float? value, float maxValue, string message)
        {
            Null(value, message);
            GreaterThanSingle(value.Value, maxValue, message);
        }

        public static void GreaterThanTimeSpan(TimeSpan? value, TimeSpan maxValue, string message)
        {
            Null(value, message);
            GreaterThanTimeSpan(value.Value, maxValue, message);
        }

        public static void GreaterThanUInt16(ushort? value, ushort maxValue, string message)
        {
            Null(value, message);
            GreaterThanUInt16(value.Value, maxValue, message);
        }

        public static void GreaterThanUInt32(uint? value, uint maxValue, string message)
        {
            Null(value, message);
            GreaterThanUInt32(value.Value, maxValue, message);
        }

        public static void GreaterThanUInt64(ulong? value, ulong maxValue, string message)
        {
            Null(value, message);
            GreaterThanUInt64(value.Value, maxValue, message);
        }
    }
}
