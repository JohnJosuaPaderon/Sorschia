using System;

namespace Sorschia
{
    partial class Validator
    {
        public static void LessThanOrEqualByte(byte value, byte minValue, string message)
        {
            if (value <= minValue)
            {
                throw new ValidationException(message, ValidationType.LessThanOrEqual);
            }
        }

        public static void LessThanOrEqualDateTime(DateTime value, DateTime minValue, string message)
        {
            if (value <= minValue)
            {
                throw new ValidationException(message, ValidationType.LessThanOrEqual);
            }
        }

        public static void LessThanOrEqualDecimal(decimal value, byte minValue, string message)
        {
            if (value <= minValue)
            {
                throw new ValidationException(message, ValidationType.LessThanOrEqual);
            }
        }

        public static void LessThanOrEqualDouble(double value, double minValue, string message)
        {
            if (value <= minValue)
            {
                throw new ValidationException(message, ValidationType.LessThanOrEqual);
            }
        }

        public static void LessThanOrEqualInt16(short value, short minValue, string message)
        {
            if (value <= minValue)
            {
                throw new ValidationException(message, ValidationType.LessThanOrEqual);
            }
        }

        public static void LessThanOrEqualInt32(int value, int minValue, string message)
        {
            if (value <= minValue)
            {
                throw new ValidationException(message, ValidationType.LessThanOrEqual);
            }
        }

        public static void LessThanOrEqualInt64(long value, long minValue, string message)
        {
            if (value <= minValue)
            {
                throw new ValidationException(message, ValidationType.LessThanOrEqual);
            }
        }

        public static void LessThanOrEqualSByte(sbyte value, sbyte minValue, string message)
        {
            if (value <= minValue)
            {
                throw new ValidationException(message, ValidationType.LessThanOrEqual);
            }
        }

        public static void LessThanOrEqualSingle(float value, float minValue, string message)
        {
            if (value <= minValue)
            {
                throw new ValidationException(message, ValidationType.LessThanOrEqual);
            }
        }

        public static void LessThanOrEqualTimeSpan(TimeSpan value, TimeSpan minValue, string message)
        {
            if (value <= minValue)
            {
                throw new ValidationException(message, ValidationType.LessThanOrEqual);
            }
        }

        public static void LessThanOrEqualUInt16(ushort value, ushort minValue, string message)
        {
            if (value <= minValue)
            {
                throw new ValidationException(message, ValidationType.LessThanOrEqual);
            }
        }

        public static void LessThanOrEqualUInt32(uint value, uint minValue, string message)
        {
            if (value <= minValue)
            {
                throw new ValidationException(message, ValidationType.LessThanOrEqual);
            }
        }

        public static void LessThanOrEqualUInt64(ulong value, ulong minValue, string message)
        {
            if (value <= minValue)
            {
                throw new ValidationException(message, ValidationType.LessThanOrEqual);
            }
        }

        public static void LessThanOrEqualSByte(byte? value, byte minValue, string message)
        {
            Null(value, message);
            LessThanOrEqualSByte(value.Value, minValue, message);
        }

        public static void LessThanOrEqualDateTime(DateTime? value, DateTime minValue, string message)
        {
            Null(value, message);
            LessThanOrEqualDateTime(value.Value, minValue, message);
        }

        public static void LessThanOrEqualDecimal(decimal? value, decimal minValue, string message)
        {
            Null(value, message);
            LessThanOrEqualDecimal(value.Value, minValue, message);
        }

        public static void LessThanOrEqualDouble(double? value, double minValue, string message)
        {
            Null(value, message);
            LessThanOrEqualDouble(value.Value, minValue, message);
        }

        public static void LessThanOrEqualInt16(short? value, short minValue, string message)
        {
            Null(value, message);
            LessThanOrEqualInt16(value.Value, minValue, message);
        }

        public static void LessThanOrEqualInt32(int? value, int minValue, string message)
        {
            Null(value, message);
            LessThanOrEqualInt32(value.Value, minValue, message);
        }

        public static void LessThanOrEqualInt64(long? value, long minValue, string message)
        {
            Null(value, message);
            LessThanOrEqualInt64(value.Value, minValue, message);
        }

        public static void LessThanOrEqualSByte(sbyte? value, sbyte minValue, string message)
        {
            Null(value, message);
            LessThanOrEqualSByte(value.Value, minValue, message);
        }

        public static void LessThanOrEqualSingle(float? value, float minValue, string message)
        {
            Null(value, message);
            LessThanOrEqualSingle(value.Value, minValue, message);
        }

        public static void LessThanOrEqualTimeSpan(TimeSpan? value, TimeSpan minValue, string message)
        {
            Null(value, message);
            LessThanOrEqualTimeSpan(value.Value, minValue, message);
        }

        public static void LessThanOrEqualUInt16(ushort? value, ushort minValue, string message)
        {
            Null(value, message);
            LessThanOrEqualUInt16(value.Value, minValue, message);
        }

        public static void LessThanOrEqualUInt32(uint? value, uint minValue, string message)
        {
            Null(value, message);
            LessThanOrEqualUInt32(value.Value, minValue, message);
        }

        public static void LessThanOrEqualUInt64(ulong? value, ulong minValue, string message)
        {
            Null(value, message);
            LessThanOrEqualUInt64(value.Value, minValue, message);
        }
    }
}
