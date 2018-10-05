using System;
using System.Collections.Generic;
using System.Text;

namespace Sorschia
{
    public static class PropertyHelper
    {
        public static void Set<T>(ref T backingField, T value)
        {
            if (!Equals(backingField, value))
            {
                backingField = value;
            }
        }

        public static void Set<T>(ref T backingField, T value, Action<T> onChanged)
        {
            if (!Equals(backingField, value))
            {
                backingField = value;
                onChanged(value);
            }
        }

        public static void Set<T>(ref T backingField, T value, Action<T, T> onChanged)
        {
            if (!Equals(backingField, value))
            {
                var previous = backingField;
                backingField = value;
                onChanged(previous, value);
            }
        }

        public static void Set<T>(ref T backingField, T value, Func<T, bool> validate)
        {
            if (!Equals(backingField, value))
            {
                if (validate(value))
                {
                    backingField = value;
                }
                else
                {
                    throw new ValidationException("Failed to validate property.", ValidationType.Default);
                }
            }
        }   
    }
}
