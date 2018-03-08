using System;

namespace Sorschia
{
    partial class Validator
    {
        public static void LessThan(byte value, byte minValue, string message)
        {
            if (value < minValue)
            {
                throw new ValidationException(message, ValidationType.LessThan);
            }
        }

        public static void LessThan(DateTime value, DateTime minValue, string message)
        {
            if (value < minValue)
            {
                throw new ValidationException(message, ValidationType.LessThan);
            }
        }

        public static void LessThan(decimal value, byte minValue, string message)
        {
            if (value < minValue)
            {
                throw new ValidationException(message, ValidationType.LessThan);
            }
        }

        public static void LessThan(double value, double minValue, string message)
        {
            if (value < minValue)
            {
                throw new ValidationException(message, ValidationType.LessThan);
            }
        }

        public static void LessThan(short value, short minValue, string message)
        {
            if (value < minValue)
            {
                throw new ValidationException(message, ValidationType.LessThan);
            }
        }

        public static void LessThan(int value, int minValue, string message)
        {
            if (value < minValue)
            {
                throw new ValidationException(message, ValidationType.LessThan);
            }
        }

        public static void LessThan(long value, long minValue, string message)
        {
            if (value < minValue)
            {
                throw new ValidationException(message, ValidationType.LessThan);
            }
        }

        public static void LessThan(sbyte value, sbyte minValue, string message)
        {
            if (value < minValue)
            {
                throw new ValidationException(message, ValidationType.LessThan);
            }
        }

        public static void LessThan(float value, float minValue, string message)
        {
            if (value < minValue)
            {
                throw new ValidationException(message, ValidationType.LessThan);
            }
        }

        public static void LessThan(TimeSpan value, TimeSpan minValue, string message)
        {
            if (value < minValue)
            {
                throw new ValidationException(message, ValidationType.LessThan);
            }
        }

        public static void LessThan(ushort value, ushort minValue, string message)
        {
            if (value < minValue)
            {
                throw new ValidationException(message, ValidationType.LessThan);
            }
        }

        public static void LessThan(uint value, uint minValue, string message)
        {
            if (value < minValue)
            {
                throw new ValidationException(message, ValidationType.LessThan);
            }
        }

        public static void LessThan(ulong value, ulong minValue, string message)
        {
            if (value < minValue)
            {
                throw new ValidationException(message, ValidationType.LessThan);
            }
        }

        public static void LessThan(byte? value, byte minValue, string message)
        {
            Null(value, message);
            LessThan(value.Value, minValue, message);
        }

        public static void LessThan(DateTime? value, DateTime minValue, string message)
        {
            Null(value, message);
            LessThan(value.Value, minValue, message);
        }

        public static void LessThan(decimal? value, decimal minValue, string message)
        {
            Null(value, message);
            LessThan(value.Value, minValue, message);
        }

        public static void LessThan(double? value, double minValue, string message)
        {
            Null(value, message);
            LessThan(value.Value, minValue, message);
        }

        public static void LessThan(short? value, short minValue, string message)
        {
            Null(value, message);
            LessThan(value.Value, minValue, message);
        }

        public static void LessThan(int? value, int minValue, string message)
        {
            Null(value, message);
            LessThan(value.Value, minValue, message);
        }

        public static void LessThan(long? value, long minValue, string message)
        {
            Null(value, message);
            LessThan(value.Value, minValue, message);
        }

        public static void LessThan(sbyte? value, sbyte minValue, string message)
        {
            Null(value, message);
            LessThan(value.Value, minValue, message);
        }

        public static void LessThan(float? value, float minValue, string message)
        {
            Null(value, message);
            LessThan(value.Value, minValue, message);
        }

        public static void LessThan(TimeSpan? value, TimeSpan minValue, string message)
        {
            Null(value, message);
            LessThan(value.Value, minValue, message);
        }

        public static void LessThan(ushort? value, ushort minValue, string message)
        {
            Null(value, message);
            LessThan(value.Value, minValue, message);
        }

        public static void LessThan(uint? value, uint minValue, string message)
        {
            Null(value, message);
            LessThan(value.Value, minValue, message);
        }

        public static void LessThan(ulong? value, ulong minValue, string message)
        {
            Null(value, message);
            LessThan(value.Value, minValue, message);
        }
    }
}
