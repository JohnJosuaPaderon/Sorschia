using System;

namespace Sorschia
{
    partial class Validator
    {
        public static void LessThanByte(byte value, byte minValue, string message)
        {
            if (value < minValue)
            {
                throw new ValidationException(message, ValidationType.LessThan);
            }
        }

        public static void LessThanDateTime(DateTime value, DateTime minValue, string message)
        {
            if (value < minValue)
            {
                throw new ValidationException(message, ValidationType.LessThan);
            }
        }

        public static void LessThanDecimal(decimal value, byte minValue, string message)
        {
            if (value < minValue)
            {
                throw new ValidationException(message, ValidationType.LessThan);
            }
        }

        public static void LessThanDouble(double value, double minValue, string message)
        {
            if (value < minValue)
            {
                throw new ValidationException(message, ValidationType.LessThan);
            }
        }

        public static void LessThanInt16(short value, short minValue, string message)
        {
            if (value < minValue)
            {
                throw new ValidationException(message, ValidationType.LessThan);
            }
        }

        public static void LessThanInt32(int value, int minValue, string message)
        {
            if (value < minValue)
            {
                throw new ValidationException(message, ValidationType.LessThan);
            }
        }

        public static void LessThanInt64(long value, long minValue, string message)
        {
            if (value < minValue)
            {
                throw new ValidationException(message, ValidationType.LessThan);
            }
        }

        public static void LessThanSByte(sbyte value, sbyte minValue, string message)
        {
            if (value < minValue)
            {
                throw new ValidationException(message, ValidationType.LessThan);
            }
        }

        public static void LessThanSingle(float value, float minValue, string message)
        {
            if (value < minValue)
            {
                throw new ValidationException(message, ValidationType.LessThan);
            }
        }

        public static void LessThanTimeSpan(TimeSpan value, TimeSpan minValue, string message)
        {
            if (value < minValue)
            {
                throw new ValidationException(message, ValidationType.LessThan);
            }
        }

        public static void LessThanUInt16(ushort value, ushort minValue, string message)
        {
            if (value < minValue)
            {
                throw new ValidationException(message, ValidationType.LessThan);
            }
        }

        public static void LessThanUInt32(uint value, uint minValue, string message)
        {
            if (value < minValue)
            {
                throw new ValidationException(message, ValidationType.LessThan);
            }
        }

        public static void LessThanUInt64(ulong value, ulong minValue, string message)
        {
            if (value < minValue)
            {
                throw new ValidationException(message, ValidationType.LessThan);
            }
        }

        public static void LessThanSByte(byte? value, byte minValue, string message)
        {
            Null(value, message);
            LessThanSByte(value.Value, minValue, message);
        }

        public static void LessThanDateTime(DateTime? value, DateTime minValue, string message)
        {
            Null(value, message);
            LessThanDateTime(value.Value, minValue, message);
        }

        public static void LessThanDecimal(decimal? value, decimal minValue, string message)
        {
            Null(value, message);
            LessThanDecimal(value.Value, minValue, message);
        }

        public static void LessThanDouble(double? value, double minValue, string message)
        {
            Null(value, message);
            LessThanDouble(value.Value, minValue, message);
        }

        public static void LessThanInt16(short? value, short minValue, string message)
        {
            Null(value, message);
            LessThanInt16(value.Value, minValue, message);
        }

        public static void LessThanInt32(int? value, int minValue, string message)
        {
            Null(value, message);
            LessThanInt32(value.Value, minValue, message);
        }

        public static void LessThanInt64(long? value, long minValue, string message)
        {
            Null(value, message);
            LessThanInt64(value.Value, minValue, message);
        }

        public static void LessThanSByte(sbyte? value, sbyte minValue, string message)
        {
            Null(value, message);
            LessThanSByte(value.Value, minValue, message);
        }

        public static void LessThanSingle(float? value, float minValue, string message)
        {
            Null(value, message);
            LessThanSingle(value.Value, minValue, message);
        }

        public static void LessThanTimeSpan(TimeSpan? value, TimeSpan minValue, string message)
        {
            Null(value, message);
            LessThanTimeSpan(value.Value, minValue, message);
        }

        public static void LessThanUInt16(ushort? value, ushort minValue, string message)
        {
            Null(value, message);
            LessThanUInt16(value.Value, minValue, message);
        }

        public static void LessThanUInt32(uint? value, uint minValue, string message)
        {
            Null(value, message);
            LessThanUInt32(value.Value, minValue, message);
        }

        public static void LessThanUInt64(ulong? value, ulong minValue, string message)
        {
            Null(value, message);
            LessThanUInt64(value.Value, minValue, message);
        }
    }
}
