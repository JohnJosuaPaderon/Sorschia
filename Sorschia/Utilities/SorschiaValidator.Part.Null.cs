namespace Sorschia.Utilities
{
    partial class SorschiaValidator
    {
        public static void Null(object value)
        {
            if (value == null)
            {
                throw new ValidationException(ConstructMessage("Value is null."), ValidationType.Null);
            }
        }

        public static void Null<TOwner>(object value, string propertyName)
        {
            if (value == null)
            {
                throw new ValidationException(ConstructMessage($"Value of {typeof(TOwner).FullName}.{propertyName} is null."), ValidationType.Null);
            }
        }
    }
}
