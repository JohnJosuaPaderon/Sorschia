using System;

namespace Sorschia.Utilities
{
    [Obsolete("Use Sorschia.Validator class instead.")]
    public static partial class SorschiaValidator
    {
        private const string INITIAL_MESSAGE = "Validation Failed.";

            private static string ConstructMessage(string message)
            {
                return $"{INITIAL_MESSAGE} {message}";
            }
    }
}
