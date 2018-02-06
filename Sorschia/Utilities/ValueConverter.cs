using System;

namespace Sorschia.Utilities
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
    }
}
