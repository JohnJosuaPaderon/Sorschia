using System.Collections.Generic;
using System.Linq;

namespace Sorschia.Utilities
{
    public static class SorschiaValidator
    {
        private const string INITIAL_MESSAGE = "Validation Failed.";

        private static string ConstructMessage(string message)
        {
            return $"{INITIAL_MESSAGE} {message}";
        }

        public static void Null(object value)
        {
            if (value == null)
            {
                throw new ValidationException(ConstructMessage("Value is null."));
            }
        }

        public static void EmptyEnumerable(IEnumerable<object> enumerable)
        {
            Null(enumerable);

            if (!enumerable.Any())
            {
                throw new ValidationException(ConstructMessage("enumerable is empty."));
            }
        }

        public static void NullOrWhiteSpace(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ValidationException(ConstructMessage("string is null or white space."));
            }
        }

        public static void Null<TOwner>(object value, string propertyName)
        {
            if (value == null)
            {
                throw new ValidationException(ConstructMessage($"Value of {typeof(TOwner).FullName}.{propertyName} is null."));
            }
        }

        public static void EmptyEnumerable<TOwner>(IEnumerable<object> enumerable, string propertyName)
        {
            Null<TOwner>(enumerable, propertyName);

            if (!enumerable.Any())
            {
                throw new ValidationException(ConstructMessage($"Enumerable {typeof(TOwner).FullName}.{propertyName} is empty."));
            }
        }

        public static void NullOrWhiteSpace<TOwner>(string value, string propertyName)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ValidationException(ConstructMessage($"Value of {typeof(TOwner).FullName}.{propertyName} is null or white space."));
            }
        }
    }
}
