using Sorschia.Converter;
using Sorschia.Data;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading;
using System.Threading.Tasks;

namespace Sorschia.Process
{
    public abstract class ReadIEnumerableDataProcessBase<T, TCommand, TConverter> : DbProcessBase<TCommand>
        where TCommand : DbCommand
        where TConverter : IDataConverter<T>
    {
        public ReadIEnumerableDataProcessBase(IProcessContextManager contextManager, IDbProcessor<TCommand> processor, TConverter converter, string schema = null) : base(contextManager, processor, schema)
        {
            Converter = converter;
        }

        private TConverter Converter { get; }

        protected virtual void ConfigureConverter(TConverter converter)
        {
            // Override to set converter properties.
        }

        public virtual IEnumerable<T> Execute(IProcessContext context)
        {
            ConfigureConverter(Converter);
            return Processor.ExecuteIEnumerableRead(context, ConstructQuery(), Converter);
        }

        public virtual Task<IEnumerable<T>> ExecuteAsync(IProcessContext context)
        {
            ConfigureConverter(Converter);
            return Processor.ExecuteIEnumerableReadAsync(context, ConstructQuery(), Converter);
        }

        public virtual Task<IEnumerable<T>> ExecuteAsync(IProcessContext context, CancellationToken cancellationToken)
        {
            ConfigureConverter(Converter);
            return Processor.ExecuteIEnumerableReadAsync(context, ConstructQuery(), Converter, cancellationToken);
        }
    }

    public abstract class ReadIEnumerableDataProcessBase<T, TCommand, TConverter, TParameters> : ReadIEnumerableDataProcessBase<T, TCommand, TConverter>
        where TCommand : DbCommand
        where TConverter : IDataConverter<T>
    {
        public ReadIEnumerableDataProcessBase(IProcessContextManager contextManager, IDbProcessor<TCommand> processor, TConverter converter, TParameters parameters, string schema = null) : base(contextManager, processor, converter, schema)
        {
            Parameters = parameters;
        }

        protected TParameters Parameters { get; }
    }
}
