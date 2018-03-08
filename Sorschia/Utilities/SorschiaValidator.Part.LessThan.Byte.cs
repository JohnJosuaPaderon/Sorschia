namespace Sorschia.Utilities
{
    partial class SorschiaValidator
    {
        public static void LessThan(byte minValue, byte value)
        {
            if (value < minValue)
            {
                throw new ValidationException(ConstructMessage($"Value should not be less than {minValue}."), ValidationType.Null);
            }
        }

        public static void LessThan<TOwner>(byte minValue, byte value, string propertyName)
        {
            if (value < minValue)
            {
                throw new ValidationException(ConstructMessage($"Value of {typeof(TOwner).FullName}.{propertyName} should not be less than {minValue}."), ValidationType.Null);
            }
        }
    }
}
