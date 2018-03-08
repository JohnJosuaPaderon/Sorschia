using System;

namespace Sorschia
{
    partial class Validator
    {public static void LessThanOrEqual(byte value, byte minValue, string message)
        {
            if (value <= minValue)
            {
                throw new ValidationException(message, ValidationType.LessThanOrEqual);
            }
        }

        public static void LessThanOrEqual(DateTime value, DateTime minValue, string message)
        {
            if (value <= minValue)
            {
                throw new ValidationException(message, ValidationType.LessThanOrEqual);
            }
        }

        public static void LessThanOrEqual(decimal value, byte minValue, string message)
        {
            if (value <= minValue)
            {
                throw new ValidationException(message, ValidationType.LessThanOrEqual);
            }
        }

        public static void LessThanOrEqual(double value, double minValue, string message)
        {
            if (value <= minValue)
            {
                throw new ValidationException(message, ValidationType.LessThanOrEqual);
            }
        }

        public static void LessThanOrEqual(short value, short minValue, string message)
        {
            if (value <= minValue)
            {
                throw new ValidationException(message, ValidationType.LessThanOrEqual);
            }
        }

        public static void LessThanOrEqual(int value, int minValue, string message)
        {
            if (value <= minValue)
            {
                throw new ValidationException(message, ValidationType.LessThanOrEqual);
            }
        }

        public static void LessThanOrEqual(long value, long minValue, string message)
        {
            if (value <= minValue)
            {
                throw new ValidationException(message, ValidationType.LessThanOrEqual);
            }
        }

        public static void LessThanOrEqual(sbyte value, sbyte minValue, string message)
        {
            if (value <= minValue)
            {
                throw new ValidationException(message, ValidationType.LessThanOrEqual);
            }
        }

        public static void LessThanOrEqual(float value, float minValue, string message)
        {
            if (value <= minValue)
            {
                throw new ValidationException(message, ValidationType.LessThanOrEqual);
            }
        }

        public static void LessThanOrEqual(TimeSpan value, TimeSpan minValue, string message)
        {
            if (value <= minValue)
            {
                throw new ValidationException(message, ValidationType.LessThanOrEqual);
            }
        }

        public static void LessThanOrEqual(ushort value, ushort minValue, string message)
        {
            if (value <= minValue)
            {
                throw new ValidationException(message, ValidationType.LessThanOrEqual);
            }
        }

        public static void LessThanOrEqual(uint value, uint minValue, string message)
        {
            if (value <= minValue)
            {
                throw new ValidationException(message, ValidationType.LessThanOrEqual);
            }
        }

        public static void LessThanOrEqual(ulong value, ulong minValue, string message)
        {
            if (value <= minValue)
            {
                throw new ValidationException(message, ValidationType.LessThanOrEqual);
            }
        }

        public static void LessThanOrEqual(byte? value, byte minValue, string message)
        {
            Null(value, message);
            LessThanOrEqual(value.Value, minValue, message);
        }

        public static void LessThanOrEqual(DateTime? value, DateTime minValue, string message)
        {
            Null(value, message);
            LessThanOrEqual(value.Value, minValue, message);
        }

        public static void LessThanOrEqual(decimal? value, decimal minValue, string message)
        {
            Null(value, message);
            LessThanOrEqual(value.Value, minValue, message);
        }

        public static void LessThanOrEqual(double? value, double minValue, string message)
        {
            Null(value, message);
            LessThanOrEqual(value.Value, minValue, message);
        }

        public static void LessThanOrEqual(short? value, short minValue, string message)
        {
            Null(value, message);
            LessThanOrEqual(value.Value, minValue, message);
        }

        public static void LessThanOrEqual(int? value, int minValue, string message)
        {
            Null(value, message);
            LessThanOrEqual(value.Value, minValue, message);
        }

        public static void LessThanOrEqual(long? value, long minValue, string message)
        {
            Null(value, message);
            LessThanOrEqual(value.Value, minValue, message);
        }

        public static void LessThanOrEqual(sbyte? value, sbyte minValue, string message)
        {
            Null(value, message);
            LessThanOrEqual(value.Value, minValue, message);
        }

        public static void LessThanOrEqual(float? value, float minValue, string message)
        {
            Null(value, message);
            LessThanOrEqual(value.Value, minValue, message);
        }

        public static void LessThanOrEqual(TimeSpan? value, TimeSpan minValue, string message)
        {
            Null(value, message);
            LessThanOrEqual(value.Value, minValue, message);
        }

        public static void LessThanOrEqual(ushort? value, ushort minValue, string message)
        {
            Null(value, message);
            LessThanOrEqual(value.Value, minValue, message);
        }

        public static void LessThanOrEqual(uint? value, uint minValue, string message)
        {
            Null(value, message);
            LessThanOrEqual(value.Value, minValue, message);
        }

        public static void LessThanOrEqual(ulong? value, ulong minValue, string message)
        {
            Null(value, message);
            LessThanOrEqual(value.Value, minValue, message);
        }
    }
}
