using Sorschia.Data;
using System.Data.Common;
using System.Threading;
using System.Threading.Tasks;

namespace Sorschia.Process
{
    public abstract class DbReadProcessBase<T, TCommand, TConverter> : DbProcessBase<TCommand>
        where TCommand : DbCommand
        where TConverter : IDbDataReaderConverter<T>
    {
        public DbReadProcessBase(IProcessContextManager contextManager, IDbProcessor<TCommand> processor, TConverter converter, string schema = null) : base(contextManager, processor, schema)
        {
            _Converter = converter;
        }

        private readonly TConverter _Converter;

        protected virtual void PrepareConverter(TConverter converter)
        {
            converter.Reset();
        }

        public T Execute(IProcessContext context)
        {
            PrepareConverter(_Converter);
            return _Processor.ExecuteReader(context, ConstructQuery(), _Converter);
        }

        public Task<T> ExecuteAsync(IProcessContext context)
        {
            PrepareConverter(_Converter);
            return _Processor.ExecuteReaderAsync(context, ConstructQuery(), _Converter);
        }

        public Task<T> ExecuteAsync(IProcessContext context, CancellationToken cancellationToken)
        {
            PrepareConverter(_Converter);
            return _Processor.ExecuteReaderAsync(context, ConstructQuery(), _Converter, cancellationToken);
        }
    }
}
