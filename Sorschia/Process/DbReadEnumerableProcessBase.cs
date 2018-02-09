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
        public DbReadEnumerableProcessBase(IProcessContextManager contextManager, IDbProcessor<TCommand> processor, string schema = null) : base(contextManager, processor, schema)
        {
        }

        protected readonly TConverter _Converter;

        protected abstract void PrepareConverter(TConverter converter);

        public IEnumerable<T> Execute(IProcessContext context)
        {
            _Converter.Reset();
            PrepareConverter(_Converter);
            return _Processor.ExecuteReaderEnumerable(context, ConstructQuery(), _Converter);
        }

        public Task<IEnumerable<T>> ExecuteAsync(IProcessContext context)
        {
            _Converter.Reset();
            PrepareConverter(_Converter);
            return _Processor.ExecuteReaderEnumerableAsync(context, ConstructQuery(), _Converter);
        }

        public Task<IEnumerable<T>> ExecuteAsync(IProcessContext context, CancellationToken cancellationToken)
        {
            _Converter.Reset();
            PrepareConverter(_Converter);
            return _Processor.ExecuteReaderEnumerableAsync(context, ConstructQuery(), _Converter, cancellationToken);
        }
    }
}
