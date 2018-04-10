using Sorschia.Data;
using System;
using System.Data.Common;
using System.Threading;
using System.Threading.Tasks;

namespace Sorschia.Process
{
    [Obsolete]
    public abstract class DbReadProcessBase<T, TCommand, TConverter> : DbProcessBase<TCommand>
        where TCommand : DbCommand
        where TConverter : IDbDataReaderConverter<T>
    {
        public DbReadProcessBase(IProcessContextManager contextManager, IDbProcessor<TCommand> processor, TConverter converter, string schema = null) : base(contextManager, processor, schema)
        {
            Converter = converter;
        }

        private TConverter Converter { get; }

        protected virtual void ConfigureConverter(TConverter converter)
        {
            converter.Reset();
        }

        public T Execute(IProcessContext context)
        {
            ConfigureConverter(Converter);
            return Processor.ExecuteReader(context, ConstructQuery(), Converter);
        }

        public Task<T> ExecuteAsync(IProcessContext context)
        {
            ConfigureConverter(Converter);
            return Processor.ExecuteReaderAsync(context, ConstructQuery(), Converter);
        }

        public Task<T> ExecuteAsync(IProcessContext context, CancellationToken cancellationToken)
        {
            ConfigureConverter(Converter);
            return Processor.ExecuteReaderAsync(context, ConstructQuery(), Converter, cancellationToken);
        }
    }

    [Obsolete]
    public abstract class DbReadProcessBase<T, TCommand, TConverter, TParameters> : DbReadProcessBase<T, TCommand, TConverter>
        where TCommand : DbCommand
        where TConverter : IDbDataReaderConverter<T>
    {
        public DbReadProcessBase(IProcessContextManager contextManager, IDbProcessor<TCommand> processor, TConverter converter, TParameters parameters, string schema = null) : base(contextManager, processor, converter, schema)
        {
            Parameters = parameters;
        }

        protected TParameters Parameters { get; }
    }
}
