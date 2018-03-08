using System.Collections.Generic;
using System.Linq;

namespace Sorschia.Utilities
{
    partial class SorschiaValidator
    {
        public static void EmptyEnumerable(IEnumerable<object> enumerable)
        {
            Null(enumerable);

            if (!enumerable.Any())
            {
                throw new ValidationException(ConstructMessage("enumerable is empty."), ValidationType.Null);
            }
        }

        public static void EmptyEnumerable<TOwner>(IEnumerable<object> enumerable, string propertyName)
        {
            Null<TOwner>(enumerable, propertyName);

            if (!enumerable.Any())
            {
                throw new ValidationException(ConstructMessage($"Enumerable {typeof(TOwner).FullName}.{propertyName} is empty."), ValidationType.Null);
            }
        }
    }
}
