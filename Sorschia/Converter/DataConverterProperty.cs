using System;
using System.Threading;
using System.Threading.Tasks;

namespace Sorschia.Converter
{
    public sealed class DataConverterProperty<T>
    {
        public DataConverterProperty()
        {

        }

        public DataConverterProperty(T value)
        {
            Value = value;
        }

        public bool UseProvidedValue { get; set; }

        private T _value;
        public T Value
        {
            get { return _value; }
            set
            {
                UseProvidedValue = true;
                _value = value;
            }
        }

        public T TryGetValue(T alternativeValue)
        {
            return UseProvidedValue ? Value : alternativeValue;
        }

        public T TryGetValue(Func<string, T> getValue, string name)
        {
            return UseProvidedValue ? Value : getValue(name);
        }

        public T TryGetProcessValue<TId>(Func<TId, T> getValue, Func<string, TId> getId, string idName)
        {
            return UseProvidedValue ? Value : getValue(getId(idName));
        }

        public async Task<T> TryGetProcessValueAsync<TId>(Func<TId, Task<T>> getValueAsync, Func<string, TId> getId, string idName)
        {
            return UseProvidedValue ? Value : await getValueAsync(getId(idName));
        }

        public async Task<T> TryGetProcessValueAsync<TId>(Func<TId, CancellationToken, Task<T>> getValueAsync, Func<string, TId> getId, string idName, CancellationToken cancellationToken)
        {
            return UseProvidedValue ? Value : await getValueAsync(getId(idName), cancellationToken);
        }

        public T TryGetProcessValue<TId>(Func<TId, bool, T> getValue, Func<string, TId> getId, string idName, bool localFirst)
        {
            return UseProvidedValue ? Value : getValue(getId(idName), localFirst);
        }

        public async Task<T> TryGetProcessValueAsync<TId>(Func<TId, bool, Task<T>> getValueAsync, Func<string, TId> getId, string idName, bool localFirst)
        {
            return UseProvidedValue ? Value : await getValueAsync(getId(idName), localFirst);
        }

        public async Task<T> TryGetProcessValueAsync<TId>(Func<TId, bool, CancellationToken, Task<T>> getValueAsync, Func<string, TId> getId, string idName, bool localFirst, CancellationToken cancellationToken)
        {
            return UseProvidedValue ? Value : await getValueAsync(getId(idName), localFirst, cancellationToken);
        }
    }
}
