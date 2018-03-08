using System;

namespace Sorschia
{
    partial class Validator
    {
        public static void GreaterThanOrEqual(byte value, byte maxValue, string message)
        {
            if (value >= maxValue)
            {
                throw new ValidationException(message, ValidationType.GreaterThanOrEqual);
            }
        }

        public static void GreaterThanOrEqual(DateTime value, DateTime maxValue, string message)
        {
            if (value >= maxValue)
            {
                throw new ValidationException(message, ValidationType.GreaterThanOrEqual);
            }
        }

        public static void GreaterThanOrEqual(decimal value, byte maxValue, string message)
        {
            if (value >= maxValue)
            {
                throw new ValidationException(message, ValidationType.GreaterThanOrEqual);
            }
        }

        public static void GreaterThanOrEqual(double value, double maxValue, string message)
        {
            if (value >= maxValue)
            {
                throw new ValidationException(message, ValidationType.GreaterThanOrEqual);
            }
        }

        public static void GreaterThanOrEqual(short value, short maxValue, string message)
        {
            if (value >= maxValue)
            {
                throw new ValidationException(message, ValidationType.GreaterThanOrEqual);
            }
        }

        public static void GreaterThanOrEqual(int value, int maxValue, string message)
        {
            if (value >= maxValue)
            {
                throw new ValidationException(message, ValidationType.GreaterThanOrEqual);
            }
        }

        public static void GreaterThanOrEqual(long value, long maxValue, string message)
        {
            if (value >= maxValue)
            {
                throw new ValidationException(message, ValidationType.GreaterThanOrEqual);
            }
        }

        public static void GreaterThanOrEqual(sbyte value, sbyte maxValue, string message)
        {
            if (value >= maxValue)
            {
                throw new ValidationException(message, ValidationType.GreaterThanOrEqual);
            }
        }

        public static void GreaterThanOrEqual(float value, float maxValue, string message)
        {
            if (value >= maxValue)
            {
                throw new ValidationException(message, ValidationType.GreaterThanOrEqual);
            }
        }

        public static void GreaterThanOrEqual(TimeSpan value, TimeSpan maxValue, string message)
        {
            if (value >= maxValue)
            {
                throw new ValidationException(message, ValidationType.GreaterThanOrEqual);
            }
        }

        public static void GreaterThanOrEqual(ushort value, ushort maxValue, string message)
        {
            if (value >= maxValue)
            {
                throw new ValidationException(message, ValidationType.GreaterThanOrEqual);
            }
        }

        public static void GreaterThanOrEqual(uint value, uint maxValue, string message)
        {
            if (value >= maxValue)
            {
                throw new ValidationException(message, ValidationType.GreaterThanOrEqual);
            }
        }

        public static void GreaterThanOrEqual(ulong value, ulong maxValue, string message)
        {
            if (value >= maxValue)
            {
                throw new ValidationException(message, ValidationType.GreaterThanOrEqual);
            }
        }

        public static void GreaterThanOrEqual(byte? value, byte maxValue, string message)
        {
            Null(value, message);
            GreaterThanOrEqual(value.Value, maxValue, message);
        }

        public static void GreaterThanOrEqual(DateTime? value, DateTime maxValue, string message)
        {
            Null(value, message);
            GreaterThanOrEqual(value.Value, maxValue, message);
        }

        public static void GreaterThanOrEqual(decimal? value, decimal maxValue, string message)
        {
            Null(value, message);
            GreaterThanOrEqual(value.Value, maxValue, message);
        }

        public static void GreaterThanOrEqual(double? value, double maxValue, string message)
        {
            Null(value, message);
            GreaterThanOrEqual(value.Value, maxValue, message);
        }

        public static void GreaterThanOrEqual(short? value, short maxValue, string message)
        {
            Null(value, message);
            GreaterThanOrEqual(value.Value, maxValue, message);
        }

        public static void GreaterThanOrEqual(int? value, int maxValue, string message)
        {
            Null(value, message);
            GreaterThanOrEqual(value.Value, maxValue, message);
        }

        public static void GreaterThanOrEqual(long? value, long maxValue, string message)
        {
            Null(value, message);
            GreaterThanOrEqual(value.Value, maxValue, message);
        }

        public static void GreaterThanOrEqual(sbyte? value, sbyte maxValue, string message)
        {
            Null(value, message);
            GreaterThanOrEqual(value.Value, maxValue, message);
        }

        public static void GreaterThanOrEqual(float? value, float maxValue, string message)
        {
            Null(value, message);
            GreaterThanOrEqual(value.Value, maxValue, message);
        }

        public static void GreaterThanOrEqual(TimeSpan? value, TimeSpan maxValue, string message)
        {
            Null(value, message);
            GreaterThanOrEqual(value.Value, maxValue, message);
        }

        public static void GreaterThanOrEqual(ushort? value, ushort maxValue, string message)
        {
            Null(value, message);
            GreaterThanOrEqual(value.Value, maxValue, message);
        }

        public static void GreaterThanOrEqual(uint? value, uint maxValue, string message)
        {
            Null(value, message);
            GreaterThanOrEqual(value.Value, maxValue, message);
        }

        public static void GreaterThanOrEqual(ulong? value, ulong maxValue, string message)
        {
            Null(value, message);
            GreaterThanOrEqual(value.Value, maxValue, message);
        }
    }
}
