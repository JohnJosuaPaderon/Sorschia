using Sorschia.Converter;
using Sorschia.Data;
using System.Data.Common;
using System.Threading;
using System.Threading.Tasks;

namespace Sorschia.Process
{
    public abstract class ReadDataProcessBase<T, TCommand, TConverter> : DbProcessBase<TCommand>
        where TCommand : DbCommand
        where TConverter : IDataConverter<T>
    {
        public ReadDataProcessBase(IProcessContextManager contextManager, IDbProcessor<TCommand> processor, TConverter converter, string schema = null) : base(contextManager, processor, schema)
        {
            Converter = converter;
        }

        private TConverter Converter { get; }

        protected virtual void ConfigureConverter(TConverter converter)
        {
            // Override to set coverter properties.
        }

        public virtual T Execute(IProcessContext context)
        {
            ConfigureConverter(Converter);
            return Processor.ExecuteRead(context, ConstructQuery(), Converter);
        }

        public virtual Task<T> ExecuteAsync(IProcessContext context)
        {
            ConfigureConverter(Converter);
            return Processor.ExecuteReadAsync(context, ConstructQuery(), Converter);
        }

        public virtual Task<T> ExecuteAsync(IProcessContext context, CancellationToken cancellationToken)
        {
            ConfigureConverter(Converter);
            return Processor.ExecuteReadAsync(context, ConstructQuery(), Converter, cancellationToken);
        }
    }

    public abstract class ReadDataProcessBase<T, TCommand, TConverter, TParameters> : ReadDataProcessBase<T, TCommand, TConverter>
        where TCommand : DbCommand
        where TConverter : IDataConverter<T>
    {
        public ReadDataProcessBase(IProcessContextManager contextManager, IDbProcessor<TCommand> processor, TConverter converter, TParameters parameters, string schema = null) : base(contextManager, processor, converter, schema)
        {
            Parameters = parameters;
        }

        protected TParameters Parameters { get; }
    }
}
