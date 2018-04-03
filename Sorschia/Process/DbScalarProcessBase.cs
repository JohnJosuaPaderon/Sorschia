using Sorschia.Data;
using System;
using System.Data.Common;
using System.Threading;
using System.Threading.Tasks;

namespace Sorschia.Process
{
    public abstract class DbScalarProcessBase<T, TCommand> : DbProcessBase<TCommand>
        where TCommand : DbCommand
    {
        public DbScalarProcessBase(IProcessContextManager contextManager, IDbProcessor<TCommand> processor, Func<object, T> convert, string schema = null) : base(contextManager, processor, schema)
        {
            Convert = convert;
        }

        private Func<object, T> Convert { get; }

        public T Execute(IProcessContext context)
        {
            return Processor.ExecuteScalar(context, ConstructQuery(), Convert);
        }

        public Task<T> ExecuteAsync(IProcessContext context)
        {
            return Processor.ExecuteScalarAsync(context, ConstructQuery(), Convert);
        }

        public Task<T> ExecuteAsync(IProcessContext context, CancellationToken cancellationToken)
        {
            return Processor.ExecuteScalarAsync(context, ConstructQuery(), Convert, cancellationToken);
        }
    }

    public abstract class DbScalarProcessBase<T, TParameters, TCommand> : DbScalarProcessBase<T, TCommand>
        where TCommand : DbCommand
    {
        public DbScalarProcessBase(IProcessContextManager contextManager, IDbProcessor<TCommand> processor, TParameters parameters, Func<object, T> convert, string schema = null) : base(contextManager, processor, convert, schema)
        {
            Parameters = parameters;
        }

        protected TParameters Parameters { get; }
    }
}
