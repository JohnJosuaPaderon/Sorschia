using Sorschia.Data;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading;
using System.Threading.Tasks;

namespace Sorschia.Converter
{
    public abstract class DataConverterBase<T>
    {
        public DataConverterBase()
        {
            MemoryFirst = ConverterConfiguration.DefaultMemoryFirst;
        }

        public bool MemoryFirst { get; }

        protected abstract T Extract(DbDataReader reader);

        protected virtual Task<T> ExtractAsync(DbDataReader reader)
        {
            return Task.FromResult(Extract(reader));
        }

        protected virtual Task<T> ExtractAsync(DbDataReader reader, CancellationToken cancellationToken)
        {
            return Task.FromResult(Extract(reader));
        }

        public T Convert(DbDataReader reader)
        {
            reader.Read();
            return Extract(reader);
        }

        public async Task<T> ConvertAsync(DbDataReader reader)
        {
            await reader.ReadAsync();
            return await ExtractAsync(reader);
        }

        public async Task<T> ConvertAsync(DbDataReader reader, CancellationToken cancellationToken)
        {
            await reader.ReadAsync(cancellationToken);
            return await ExtractAsync(reader, cancellationToken);
        }

        public IEnumerable<T> IEnumerableConvert(DbDataReader reader)
        {
            var result = new List<T>();
            while (reader.Read()) result.Add(Extract(reader));
            return result;
        }

        public async Task<IEnumerable<T>> IEnumerableConvertAsync(DbDataReader reader)
        {
            var result = new List<T>();
            while (await reader.ReadAsync()) result.Add(await ExtractAsync(reader));
            return result;
        }

        public async Task<IEnumerable<T>> IEnumerableConvertAsync(DbDataReader reader, CancellationToken cancellationToken)
        {
            var result = new List<T>();
            while (await reader.ReadAsync()) result.Add(await ExtractAsync(reader));
            return result;
        }
    }

    public abstract class DataConverterBase<T, TFields> : DataConverterBase<T>
    {
        public DataConverterBase(TFields fields)
        {
            Fields = fields;
        }

        protected TFields Fields { get; }
    }
}
