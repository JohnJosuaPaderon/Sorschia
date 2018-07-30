using System;

namespace Sorschia
{
    public static class PropertyValidator
    {
        public static bool NullOrWhiteSpace(string value)
        {
            return !string.IsNullOrWhiteSpace(value);
        }

        public static bool NullOrWhiteSpace(string value, string errorMessage)
        {
            if (NullOrWhiteSpace(value))
            {
                return true;
            }
            else
            {
                throw new ValidationException(errorMessage, ValidationType.NullOrWhiteSpace);
            }
        }

        public static bool Null(object value)
        {
            return value != null;
        }

        public static bool Null(object value, string errorMessage)
        {
            if (Null(value))
            {
                return true;
            }
            else
            {
                throw new ValidationException(errorMessage, ValidationType.Null);
            }
        }

        public static bool Default<T>(T value)
        {
            return !Equals(value, default(T));
        }

        public static bool Default<T>(T value, string errorMessage)
        {
            if (Default(value))
            {
                return true;
            }
            else
            {
                throw new ValidationException(errorMessage, ValidationType.Default);
            }
        }

        public static bool LessThan<T>(T value, T minValue)
            where T : struct, IComparable<T>
        {
            return value.CompareTo(minValue) >= 0;
        }

        public static bool LessThan<T>(T value, T minValue, string errorMessage)
            where T : struct, IComparable<T>
        {
            if (LessThan(value, minValue))
            {
                return true;
            }
            else
            {
                throw new ValidationException(errorMessage, ValidationType.LessThan);
            }
        }

        public static bool LessThanOrEqual<T>(T value, T minValue)
            where T : struct, IComparable<T>
        {
            return value.CompareTo(minValue) > 0;
        }

        public static bool LessThanOrEqual<T>(T value, T minValue, string errorMessage)
            where T : struct, IComparable<T>
        {
            if (LessThanOrEqual(value, minValue))
            {
                return true;
            }
            else
            {
                throw new ValidationException(errorMessage, ValidationType.LessThanOrEqual);
            }
        }

        public static bool GreaterThan<T>(T value, T maxValue)
            where T : struct, IComparable<T>
        {
            return value.CompareTo(maxValue) <= 0;
        }

        public static bool GreaterThan<T>(T value, T maxValue, string errorMessage)
            where T : struct, IComparable<T>
        {
            if (GreaterThan(value, maxValue))
            {
                return true;
            }
            else
            {
                throw new ValidationException(errorMessage, ValidationType.GreaterThan);
            }
        }

        public static bool GreaterThanOrEqual<T>(T value, T maxValue)
            where T : struct, IComparable<T>
        {
            return value.CompareTo(maxValue) < 0;
        }

        public static bool GreaterThanOrEqual<T>(T value, T maxValue, string errorMessage)
            where T : struct, IComparable<T>
        {
            if (GreaterThanOrEqual(value, maxValue))
            {
                return true;
            }
            else
            {
                throw new ValidationException(errorMessage, ValidationType.GreaterThanOrEqual);
            }
        }
    }
}
