namespace Sorschia.Utilities
{
    partial class SorschiaValidator
    {
        public static void LessThanOrEqual(short minValue, short value)
        {
            if (value <= minValue)
            {
                throw new ValidationException(ConstructMessage($"Value should not be less than or equal {minValue}."), ValidationType.Null);
            }
        }

        public static void LessThanOrEqual(short value)
        {
            LessThanOrEqual(0, value);
        }

        public static void LessThanOrEqual<TOwner>(short minValue, short value, string propertyName)
        {
            if (value <= minValue)
            {
                throw new ValidationException(ConstructMessage($"Value of {typeof(TOwner).FullName}.{propertyName} should not be less than or equal {minValue}."), ValidationType.Null);
            }
        }

        public static void LessThanOrEqual<TOwner>(short value, string propertyName)
        {
            LessThanOrEqual<TOwner>(0, value, propertyName);
        }
    }
}
