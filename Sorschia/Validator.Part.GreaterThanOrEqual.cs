using System;

namespace Sorschia
{
    partial class Validator
    {
        public static void GreaterThanOrEqualByte(byte value, byte maxValue, string message)
        {
            if (value >= maxValue)
            {
                throw new ValidationException(message, ValidationType.GreaterThanOrEqual);
            }
        }

        public static void GreaterThanOrEqualDateTime(DateTime value, DateTime maxValue, string message)
        {
            if (value >= maxValue)
            {
                throw new ValidationException(message, ValidationType.GreaterThanOrEqual);
            }
        }

        public static void GreaterThanOrEqualDecimal(decimal value, byte maxValue, string message)
        {
            if (value >= maxValue)
            {
                throw new ValidationException(message, ValidationType.GreaterThanOrEqual);
            }
        }

        public static void GreaterThanOrEqualDouble(double value, double maxValue, string message)
        {
            if (value >= maxValue)
            {
                throw new ValidationException(message, ValidationType.GreaterThanOrEqual);
            }
        }

        public static void GreaterThanOrEqualInt16(short value, short maxValue, string message)
        {
            if (value >= maxValue)
            {
                throw new ValidationException(message, ValidationType.GreaterThanOrEqual);
            }
        }

        public static void GreaterThanOrEqualInt32(int value, int maxValue, string message)
        {
            if (value >= maxValue)
            {
                throw new ValidationException(message, ValidationType.GreaterThanOrEqual);
            }
        }

        public static void GreaterThanOrEqualInt64(long value, long maxValue, string message)
        {
            if (value >= maxValue)
            {
                throw new ValidationException(message, ValidationType.GreaterThanOrEqual);
            }
        }

        public static void GreaterThanOrEqualSByte(sbyte value, sbyte maxValue, string message)
        {
            if (value >= maxValue)
            {
                throw new ValidationException(message, ValidationType.GreaterThanOrEqual);
            }
        }

        public static void GreaterThanOrEqualSingle(float value, float maxValue, string message)
        {
            if (value >= maxValue)
            {
                throw new ValidationException(message, ValidationType.GreaterThanOrEqual);
            }
        }

        public static void GreaterThanOrEqualTimeSpan(TimeSpan value, TimeSpan maxValue, string message)
        {
            if (value >= maxValue)
            {
                throw new ValidationException(message, ValidationType.GreaterThanOrEqual);
            }
        }

        public static void GreaterThanOrEqualUInt16(ushort value, ushort maxValue, string message)
        {
            if (value >= maxValue)
            {
                throw new ValidationException(message, ValidationType.GreaterThanOrEqual);
            }
        }

        public static void GreaterThanOrEqualUInt32(uint value, uint maxValue, string message)
        {
            if (value >= maxValue)
            {
                throw new ValidationException(message, ValidationType.GreaterThanOrEqual);
            }
        }

        public static void GreaterThanOrEqualUInt64(ulong value, ulong maxValue, string message)
        {
            if (value >= maxValue)
            {
                throw new ValidationException(message, ValidationType.GreaterThanOrEqual);
            }
        }

        public static void GreaterThanOrEqualByte(byte? value, byte maxValue, string message)
        {
            Null(value, message);
            GreaterThanOrEqualByte(value.Value, maxValue, message);
        }

        public static void GreaterThanOrEqualDateTime(DateTime? value, DateTime maxValue, string message)
        {
            Null(value, message);
            GreaterThanOrEqualDateTime(value.Value, maxValue, message);
        }

        public static void GreaterThanOrEqualDecimal(decimal? value, decimal maxValue, string message)
        {
            Null(value, message);
            GreaterThanOrEqualDecimal(value.Value, maxValue, message);
        }

        public static void GreaterThanOrEqualDouble(double? value, double maxValue, string message)
        {
            Null(value, message);
            GreaterThanOrEqualDouble(value.Value, maxValue, message);
        }

        public static void GreaterThanOrEqualInt16(short? value, short maxValue, string message)
        {
            Null(value, message);
            GreaterThanOrEqualInt16(value.Value, maxValue, message);
        }

        public static void GreaterThanOrEqualInt32(int? value, int maxValue, string message)
        {
            Null(value, message);
            GreaterThanOrEqualInt32(value.Value, maxValue, message);
        }

        public static void GreaterThanOrEqualInt64(long? value, long maxValue, string message)
        {
            Null(value, message);
            GreaterThanOrEqualInt64(value.Value, maxValue, message);
        }

        public static void GreaterThanOrEqualSByte(sbyte? value, sbyte maxValue, string message)
        {
            Null(value, message);
            GreaterThanOrEqualSByte(value.Value, maxValue, message);
        }

        public static void GreaterThanOrEqualSingle(float? value, float maxValue, string message)
        {
            Null(value, message);
            GreaterThanOrEqualSingle(value.Value, maxValue, message);
        }

        public static void GreaterThanOrEqualTimeSpan(TimeSpan? value, TimeSpan maxValue, string message)
        {
            Null(value, message);
            GreaterThanOrEqualTimeSpan(value.Value, maxValue, message);
        }

        public static void GreaterThanOrEqualUInt16(ushort? value, ushort maxValue, string message)
        {
            Null(value, message);
            GreaterThanOrEqualUInt16(value.Value, maxValue, message);
        }

        public static void GreaterThanOrEqualUInt32(uint? value, uint maxValue, string message)
        {
            Null(value, message);
            GreaterThanOrEqualUInt32(value.Value, maxValue, message);
        }

        public static void GreaterThanOrEqualUInt64(ulong? value, ulong maxValue, string message)
        {
            Null(value, message);
            GreaterThanOrEqualUInt64(value.Value, maxValue, message);
        }
    }
}
