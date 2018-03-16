using Sorschia.Data;
using System.Data.Common;
using System.Threading;
using System.Threading.Tasks;

namespace Sorschia.Process
{
    public abstract class DbExecuteProcessBase<T, TCommand> : DbProcessBase<TCommand>
        where TCommand : DbCommand
    {
        public DbExecuteProcessBase(IProcessContextManager contextManager, IDbProcessor<TCommand> processor, string schema = null) : base(contextManager, processor, schema)
        {
        }

        protected abstract T Callback(int affectedRows, TCommand command);

        public T Execute(IProcessContext context)
        {
            return Processor.ExecuteNonQuery(context, ConstructQuery(), Callback);
        }

        public Task<T> ExecuteAsync(IProcessContext context)
        {
            return Processor.ExecuteNonQueryAsync(context, ConstructQuery(), Callback);
        }

        public Task<T> ExecuteAsync(IProcessContext context, CancellationToken cancellationToken)
        {
            return Processor.ExecuteNonQueryAsync(context, ConstructQuery(), Callback, cancellationToken);
        }
    }

    public abstract class DbExecuteProcessBase<T, TCommand, TParameters> : DbExecuteProcessBase<T, TCommand>
        where TCommand : DbCommand
    {
        public DbExecuteProcessBase(IProcessContextManager contextManager, IDbProcessor<TCommand> processor, TParameters parameters, string schema = null) : base(contextManager, processor, schema)
        {
            Parameters = parameters;
        }

        protected TParameters Parameters { get; }
    }
}
