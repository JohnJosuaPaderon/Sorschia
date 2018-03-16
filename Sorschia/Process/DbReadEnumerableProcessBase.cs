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
            Converter = converter;
        }

        protected TConverter Converter { get; }

        protected virtual void ConfigureConverter(TConverter converter)
        {
            Converter.Reset();
        }

        public IEnumerable<T> Execute(IProcessContext context)
        {
            ConfigureConverter(Converter);
            return Processor.ExecuteReaderEnumerable(context, ConstructQuery(), Converter);
        }

        public Task<IEnumerable<T>> ExecuteAsync(IProcessContext context)
        {
            ConfigureConverter(Converter);
            return Processor.ExecuteReaderEnumerableAsync(context, ConstructQuery(), Converter);
        }

        public Task<IEnumerable<T>> ExecuteAsync(IProcessContext context, CancellationToken cancellationToken)
        {
            ConfigureConverter(Converter);
            return Processor.ExecuteReaderEnumerableAsync(context, ConstructQuery(), Converter, cancellationToken);
        }
    }

    public abstract class DbReadEnumerableProcessBase<T, TCommand, TConverter, TParameters> : DbReadEnumerableProcessBase<T, TCommand, TConverter>
        where TCommand : DbCommand
        where TConverter : IDbDataReaderConverter<T>
    {
        public DbReadEnumerableProcessBase(IProcessContextManager contextManager, IDbProcessor<TCommand> processor, TConverter converter, TParameters parameters, string schema = null) : base(contextManager, processor, converter, schema)
        {
            Parameters = parameters;
        }

        protected TParameters Parameters { get; }
    }
}
