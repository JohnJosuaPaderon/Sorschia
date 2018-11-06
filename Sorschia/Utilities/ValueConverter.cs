using System;

namespace Sorschia
{
    /// <summary>
    /// Exposes functions that convert a type to another type.
    /// </summary>
    public static partial class ValueConverter
    {
        /// <summary>
        /// Determines whether the value is not set to default
        /// </summary>
        private static bool IsDefault<T>(T value)
        {
            return Equals(default(T), value);
        }

        /// <summary>
        /// Base-conversion that requires a value and a function that actually converts the value
        /// </summary>
        private static TResult ConvertBase<TInput, TResult>(TInput value, Func<TInput, TResult> convert)
        {
            return IsDefault(value) ? default(TResult) : convert(value);
        }

        /// <summary>
        /// Base-conversion that requires a value, a formatting information, and the function that actually converts the value with the specified formatting information
        /// </summary>
        private static TResult ConvertBase<TInput, TResult>(TInput value, IFormatProvider formatProvider, Func<TInput, IFormatProvider, TResult> convert)
        {
            return IsDefault(value) ? default(TResult) : convert(value, formatProvider);
        }

        /// <summary>
        /// Base-conversion for nullables that requires the value and the function that converts the value if not null.
        /// </summary>
        private static TResult? ConvertNullableBase<TInput, TResult>(TInput value, Func<TInput, TResult> convert)
            where TInput : class
            where TResult : struct
        {
            return value == null ? null : new TResult?(convert(value));
        }

        /// <summary>
        /// Base-conversion for nullables that requires the value, the formatting information and the function that requires the specified formatting information and converts the value if not null.
        /// </summary>
        private static TResult? ConvertNullableBase<TInput, TResult>(TInput value, IFormatProvider formatProvider, Func<TInput, IFormatProvider, TResult> convert)
            where TInput : class
            where TResult : struct
        {
            return value == null ? null : new TResult?(convert(value, formatProvider));
        }
    }
}
