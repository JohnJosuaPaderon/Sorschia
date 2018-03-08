using System.Collections.Generic;
using System.Linq;

namespace Sorschia
{
    public static partial class Validator
    {
        public static void NullOrWhiteSpace(string value, string message)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ValidationException(message, ValidationType.NullOrWhiteSpace);
            }
        }

        public static void Null(object value, string message)
        {
            if (value == null)
            {
                throw new ValidationException(message, ValidationType.Null);
            }
        }

        public static void Default<T>(T value, string message)
        {
            if (Equals(default(T), value))
            {
                throw new ValidationException(message, ValidationType.Default);
            }
        }

        public static void EmptyIEnumerable<T>(IEnumerable<T> enumerable, string message)
        {
            Null(enumerable, message);

            if (!enumerable.Any())
            {
                throw new ValidationException(message, ValidationType.EmptyIEnumerable);
            }
        }
    }
}
