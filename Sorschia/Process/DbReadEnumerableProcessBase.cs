using Sorschia.Data;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading;
using System.Threading.Tasks;

namespace Sorschia.Process
{
    public abstract class DbReadEnumerableProcessBase<T, TCommand, TConverter> : DbProcessBase<TCommand>
        where TCommand : DbCommand
        where TConverter : IDbDataReaderConverter<T>
    {
        public DbReadEnumerableProcessBase(IProcessContextManager contextManager, IDbProcessor<TCommand> processor, TConverter converter, string schema = null) : base(contextManager, processor, schema)
        {
            _Converter = converter;
        }

        protected readonly TConverter _Converter;

        protected virtual void PrepareConverter(TConverter converter)
        {
            _Converter.Reset();
        }

        public IEnumerable<T> Execute(IProcessContext context)
        {
            PrepareConverter(_Converter);
            return _Processor.ExecuteReaderEnumerable(context, ConstructQuery(), _Converter);
        }

        public Task<IEnumerable<T>> ExecuteAsync(IProcessContext context)
        {
            PrepareConverter(_Converter);
            return _Processor.ExecuteReaderEnumerableAsync(context, ConstructQuery(), _Converter);
        }

        public Task<IEnumerable<T>> ExecuteAsync(IProcessContext context, CancellationToken cancellationToken)
        {
            PrepareConverter(_Converter);
            return _Processor.ExecuteReaderEnumerableAsync(context, ConstructQuery(), _Converter, cancellationToken);
        }
    }
}
