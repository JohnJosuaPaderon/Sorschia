using System.Data.Common;
using System.Threading;
using System.Threading.Tasks;

namespace Sorschia
{
    public abstract class DbExecuteProcessBase<TCommand, T> : DbProcessBase<TCommand>
        where TCommand : DbCommand
    {
        public DbExecuteProcessBase(string schemaName = null) : base(schemaName)
        {
        }

        protected abstract T Callback(int affectedRows, TCommand command);

        public T Execute(IProcessContext context)
        {
            return Processor.ExecuteNonQuery(context, GetQuery(), Callback);
        }

        public Task<T> ExecuteAsync(IProcessContext context)
        {
            return Processor.ExecuteNonQueryAsync(context, GetQuery(), Callback);
        }

        public Task<T> ExecuteAsync(IProcessContext context, CancellationToken cancellationToken)
        {
            return Processor.ExecuteNonQueryAsync(context, GetQuery(), Callback, cancellationToken);
        }
    }

    public abstract class DbExecuteProcessBase<TCommand, T, TParameters> : DbExecuteProcessBase<TCommand, T>
        where TCommand : DbCommand
    {
        public DbExecuteProcessBase(string schemaName = null) : base(schemaName)
        {
        }

        private TParameters _parameters;
        protected TParameters Parameters => ServiceStore.TryResolve(ref _parameters);
    }
}
