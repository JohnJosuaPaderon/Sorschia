using System;
using System.Threading;
using System.Threading.Tasks;

namespace Sorschia.Data
{
    public static class DbDataReaderConverterPropertyExtension
    {
        public static T TryGetValue<T>(this DbDataReaderConverterProperty<T> instance, Func<string, T> getPropertry, string name)
        {
            return instance.UseProvidedValue ? instance.Value : getPropertry(name);
        }

        public static TResult TryGetValueFromProcess<TResult, TIdentifier>(this DbDataReaderConverterProperty<TResult> instance, Func<TIdentifier, TResult> getProperty, Func<string, TIdentifier> getIdentifier, string identifierField)
        {
            return instance.UseProvidedValue ? instance.Value : getProperty(getIdentifier(identifierField));
        }

        public static async Task<TResult> TryGetValueFromProcessAsync<TResult, TIdentifier>(this DbDataReaderConverterProperty<TResult> instance, Func<TIdentifier, Task<TResult>> getPropertyAsync, Func<string, TIdentifier> getIdentifier, string identifierField)
        {
            return instance.UseProvidedValue ? instance.Value : await getPropertyAsync(getIdentifier(identifierField));
        }

        public static async Task<TResult> TryGetValueFromProcessAsync<TResult, TIdentifier>(this DbDataReaderConverterProperty<TResult> instance, Func<TIdentifier, CancellationToken, Task<TResult>> getPropertyAsync, Func<string, TIdentifier> getIdentifier, string identifierField, CancellationToken cancellationToken)
        {
            return instance.UseProvidedValue ? instance.Value : await getPropertyAsync(getIdentifier(identifierField), cancellationToken);
        }
    }
}
