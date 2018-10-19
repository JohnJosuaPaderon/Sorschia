using Sorschia.Converter;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading;
using System.Threading.Tasks;

namespace Sorschia.Process
{
    public abstract class DbReadIEnumerableProcessBase<TCommand, T, TConverter> : DbProcessBase<TCommand>
        where TCommand : DbCommand
        where TConverter : IDataConverter<T>
    {
        public DbReadIEnumerableProcessBase(string schemaName = null) : base(schemaName)
        {
        }

        private TConverter _converter;
        protected TConverter Converter => ServiceStore.TryResolve(ref _converter);

        protected virtual void ConfigureConverter(TConverter converter)
        {
            // Override to set converter properties.
        }

        public virtual IEnumerable<T> Execute(IProcessContext context)
        {
            ConfigureConverter(Converter);
            return Processor.ExecuteIEnumerableRead(context, GetQuery(), Converter);
        }

        public virtual Task<IEnumerable<T>> ExecuteAsync(IProcessContext context)
        {
            ConfigureConverter(Converter);
            return Processor.ExecuteIEnumerableReadAsync(context, GetQuery(), Converter);
        }

        public virtual Task<IEnumerable<T>> ExecuteAsync(IProcessContext context, CancellationToken cancellationToken)
        {
            ConfigureConverter(Converter);
            return Processor.ExecuteIEnumerableReadAsync(context, GetQuery(), Converter, cancellationToken);
        }
    }

    public abstract class DbReadIEnumerableProcessBase<TCommand, T, TConverter, TParameters> : DbReadIEnumerableProcessBase<TCommand, T, TConverter>
        where TCommand : DbCommand
        where TConverter : IDataConverter<T>
    {
        public DbReadIEnumerableProcessBase(string schemaName = null) : base(schemaName)
        {
        }

        private TParameters _parameters;
        protected TParameters Parameters => ServiceStore.TryResolve(ref _parameters);
    }
}
