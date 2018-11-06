using System;
using System.Data.Common;
using System.Threading;
using System.Threading.Tasks;

namespace Sorschia
{
    public abstract class DbScalarProcessBase<TCommand, T> : DbProcessBase<TCommand>
        where TCommand : DbCommand
    {
        public DbScalarProcessBase(Func<object, T> convert, string schemaName = null) : base(schemaName)
        {
            Validator.Null(convert, "Invalid convert function.");
            Convert = convert;
        }

        private Func<object, T> Convert { get; }

        public virtual T Execute(IProcessContext context)
        {
            return Processor.ExecuteScalar(context, GetQuery(), Convert);
        }

        public virtual Task<T> ExecuteAsync(IProcessContext context)
        {
            return Processor.ExecuteScalarAsync(context, GetQuery(), Convert);
        }

        public virtual Task<T> ExecuteAsync(IProcessContext context, CancellationToken cancellationToken)
        {
            return Processor.ExecuteScalarAsync(context, GetQuery(), Convert, cancellationToken);
        }
    }

    public abstract class DbScalarProcessBase<TCommand, T, TParameters> : DbScalarProcessBase<TCommand, T>
        where TCommand : DbCommand
    {
        public DbScalarProcessBase(Func<object, T> convert, string schemaName = null) : base(convert, schemaName)
        {
        }

        private TParameters _parameters;
        protected TParameters Parameters => ServiceStore.TryResolve(ref _parameters);
    }
}
