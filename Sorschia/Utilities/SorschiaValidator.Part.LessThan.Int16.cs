namespace Sorschia.Utilities
{
    partial class SorschiaValidator
    {
        public static void LessThan(short minValue, short value)
        {
            if (value < minValue)
            {
                throw new ValidationException(ConstructMessage($"Value should not be less than {minValue}."), ValidationType.Null);
            }
        }

        public static void LessThan(short value)
        {
            LessThan(0, value);
        }

        public static void LessThan<TOwner>(short minValue, short value, string propertyName)
        {
            if (value < minValue)
            {
                throw new ValidationException(ConstructMessage($"Value of {typeof(TOwner).FullName}.{propertyName} should not be less than {minValue}."), ValidationType.Null);
            }
        }

        public static void LessThan<TOwner>(short value, string propertyName)
        {
            LessThan<TOwner>(0, value, propertyName);
        }
    }
}
