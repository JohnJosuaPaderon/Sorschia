using System;

namespace Sorschia.Data
{
    [Obsolete]
    public sealed class DbDataReaderConverterProperty<T>
    {
        private T _Value;

        public bool UseProvidedValue { get; set; }

        public T Value
        {
            get { return _Value; }
            set
            {
                UseProvidedValue = true;
                _Value = value;
            }
        }

        public T TryGetValue(T alternativeValue)
        {
            return UseProvidedValue ? Value : alternativeValue;
        }

        public void Reset()
        {
            UseProvidedValue = false;
            _Value = default(T);
        }
    }
}
