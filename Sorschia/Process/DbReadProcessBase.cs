using System.Data.Common;
using System.Threading;
using System.Threading.Tasks;

namespace Sorschia
{
    public abstract class DbReadProcessBase<TCommand, T, TConverter> : DbProcessBase<TCommand>
        where TCommand : DbCommand
        where TConverter : IDataConverter<T>
    {
        public DbReadProcessBase(string schemaName = null) : base(schemaName)
        {
        }

        private TConverter _converter;
        protected TConverter Converter => ServiceStore.TryResolve(ref _converter);

        protected virtual void ConfigureConverter(TConverter converter)
        {
            // Override to set converter properties.
        }

        public virtual T Execute(IProcessContext context)
        {
            ConfigureConverter(Converter);
            return Processor.ExecuteRead(context, GetQuery(), Converter);
        }

        public virtual Task<T> ExecuteAsync(IProcessContext context)
        {
            ConfigureConverter(Converter);
            return Processor.ExecuteReadAsync(context, GetQuery(), Converter);
        }

        public virtual Task<T> ExecuteAsync(IProcessContext context, CancellationToken cancellationToken)
        {
            ConfigureConverter(Converter);
            return Processor.ExecuteReadAsync(context, GetQuery(), Converter, cancellationToken);
        }
    }

    public abstract class DbReadProcessBase<TCommand, T, TConverter, TParameters> : DbReadProcessBase<TCommand, T, TConverter>
        where TCommand : DbCommand
        where TConverter : IDataConverter<T>
    {
        public DbReadProcessBase(string schemaName = null) : base(schemaName)
        {
        }

        private TParameters _parameters;
        protected TParameters Parameters => ServiceStore.TryResolve(ref _parameters);
    }
}
