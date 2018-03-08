using System;

namespace Sorschia
{
    partial class Validator
    {
        public static void GreaterThan(byte value, byte maxValue, string message)
        {
            if (value > maxValue)
            {
                throw new ValidationException(message, ValidationType.GreaterThan);
            }
        }

        public static void GreaterThan(DateTime value, DateTime maxValue, string message)
        {
            if (value > maxValue)
            {
                throw new ValidationException(message, ValidationType.GreaterThan);
            }
        }

        public static void GreaterThan(decimal value, byte maxValue, string message)
        {
            if (value > maxValue)
            {
                throw new ValidationException(message, ValidationType.GreaterThan);
            }
        }

        public static void GreaterThan(double value, double maxValue, string message)
        {
            if (value > maxValue)
            {
                throw new ValidationException(message, ValidationType.GreaterThan);
            }
        }

        public static void GreaterThan(short value, short maxValue, string message)
        {
            if (value > maxValue)
            {
                throw new ValidationException(message, ValidationType.GreaterThan);
            }
        }

        public static void GreaterThan(int value, int maxValue, string message)
        {
            if (value > maxValue)
            {
                throw new ValidationException(message, ValidationType.GreaterThan);
            }
        }

        public static void GreaterThan(long value, long maxValue, string message)
        {
            if (value > maxValue)
            {
                throw new ValidationException(message, ValidationType.GreaterThan);
            }
        }

        public static void GreaterThan(sbyte value, sbyte maxValue, string message)
        {
            if (value > maxValue)
            {
                throw new ValidationException(message, ValidationType.GreaterThan);
            }
        }

        public static void GreaterThan(float value, float maxValue, string message)
        {
            if (value > maxValue)
            {
                throw new ValidationException(message, ValidationType.GreaterThan);
            }
        }

        public static void GreaterThan(TimeSpan value, TimeSpan maxValue, string message)
        {
            if (value > maxValue)
            {
                throw new ValidationException(message, ValidationType.GreaterThan);
            }
        }

        public static void GreaterThan(ushort value, ushort maxValue, string message)
        {
            if (value > maxValue)
            {
                throw new ValidationException(message, ValidationType.GreaterThan);
            }
        }

        public static void GreaterThan(uint value, uint maxValue, string message)
        {
            if (value > maxValue)
            {
                throw new ValidationException(message, ValidationType.GreaterThan);
            }
        }

        public static void GreaterThan(ulong value, ulong maxValue, string message)
        {
            if (value > maxValue)
            {
                throw new ValidationException(message, ValidationType.GreaterThan);
            }
        }

        public static void GreaterThan(byte? value, byte maxValue, string message)
        {
            Null(value, message);
            GreaterThan(value.Value, maxValue, message);
        }

        public static void GreaterThan(DateTime? value, DateTime maxValue, string message)
        {
            Null(value, message);
            GreaterThan(value.Value, maxValue, message);
        }

        public static void GreaterThan(decimal? value, decimal maxValue, string message)
        {
            Null(value, message);
            GreaterThan(value.Value, maxValue, message);
        }

        public static void GreaterThan(double? value, double maxValue, string message)
        {
            Null(value, message);
            GreaterThan(value.Value, maxValue, message);
        }

        public static void GreaterThan(short? value, short maxValue, string message)
        {
            Null(value, message);
            GreaterThan(value.Value, maxValue, message);
        }

        public static void GreaterThan(int? value, int maxValue, string message)
        {
            Null(value, message);
            GreaterThan(value.Value, maxValue, message);
        }

        public static void GreaterThan(long? value, long maxValue, string message)
        {
            Null(value, message);
            GreaterThan(value.Value, maxValue, message);
        }

        public static void GreaterThan(sbyte? value, sbyte maxValue, string message)
        {
            Null(value, message);
            GreaterThan(value.Value, maxValue, message);
        }

        public static void GreaterThan(float? value, float maxValue, string message)
        {
            Null(value, message);
            GreaterThan(value.Value, maxValue, message);
        }

        public static void GreaterThan(TimeSpan? value, TimeSpan maxValue, string message)
        {
            Null(value, message);
            GreaterThan(value.Value, maxValue, message);
        }

        public static void GreaterThan(ushort? value, ushort maxValue, string message)
        {
            Null(value, message);
            GreaterThan(value.Value, maxValue, message);
        }

        public static void GreaterThan(uint? value, uint maxValue, string message)
        {
            Null(value, message);
            GreaterThan(value.Value, maxValue, message);
        }

        public static void GreaterThan(ulong? value, ulong maxValue, string message)
        {
            Null(value, message);
            GreaterThan(value.Value, maxValue, message);
        }
    }
}
