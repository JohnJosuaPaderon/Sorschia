namespace Sorschia.Utilities
{
    partial class SorschiaValidator
    {
        public static void NullOrWhiteSpace(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ValidationException(ConstructMessage("string is null or white space."), ValidationType.NullOrWhiteSpace);
            }
        }

        public static void NullOrWhiteSpace<TOwner>(string value, string propertyName)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ValidationException(ConstructMessage($"Value of {typeof(TOwner).FullName}.{propertyName} is null or white space."), ValidationType.NullOrWhiteSpace);
            }
        }
    }
}
