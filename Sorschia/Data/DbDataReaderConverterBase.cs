using System.Collections.Generic;
using System.Data.Common;
using System.Threading;
using System.Threading.Tasks;

namespace Sorschia.Data
{
    public abstract class DbDataReaderConverterBase<T>
    {
        public bool MemoryFirst { get; set; }
        protected abstract T Convert(DbDataReader reader);

        public virtual void Reset()
        {
            MemoryFirst = ConverterConfiguration.DefaultMemoryFirst;
        }

        protected virtual Task<T> ConvertAsync(DbDataReader reader)
        {
            return Task.FromResult(Convert(reader));
        }

        protected virtual Task<T> ConvertAsync(DbDataReader reader, CancellationToken cancellationToken)
        {
            return Task.FromResult(Convert(reader));
        }

        public T FromReader(DbDataReader reader)
        {
            reader.Read();
            return Convert(reader);
        }

        public async Task<T> FromReaderAsync(DbDataReader reader)
        {
            await reader.ReadAsync();
            return await ConvertAsync(reader);
        }

        public async Task<T> FromReaderAsync(DbDataReader reader, CancellationToken cancellationToken)
        {
            await reader.ReadAsync(cancellationToken);
            return await ConvertAsync(reader, cancellationToken);
        }

        public IEnumerable<T> EnumerableFromReader(DbDataReader reader)
        {
            var result = new List<T>();

            while (reader.Read())
            {
                result.Add(Convert(reader));
            }

            return result;
        }

        public async Task<IEnumerable<T>> EnumerableFromReaderAsync(DbDataReader reader)
        {
            var result = new List<T>();

            while (await reader.ReadAsync())
            {
                result.Add(await ConvertAsync(reader));
            }

            return result;
        }

        public async Task<IEnumerable<T>> EnumerableFromReaderAsync(DbDataReader reader, CancellationToken cancellationToken)
        {
            var result = new List<T>();

            while (await reader.ReadAsync(cancellationToken))
            {
                result.Add(await ConvertAsync(reader, cancellationToken));
            }

            return result;
        }
    }

    public abstract class DbDataReaderConverterBase<T, TFields> : DbDataReaderConverterBase<T>
    {
        public DbDataReaderConverterBase(TFields fields)
        {
            Fields = fields;
        }

        protected TFields Fields { get; }
    }
}
