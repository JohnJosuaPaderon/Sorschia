using System.Data.Common;

namespace Sorschia
{
    public abstract class DbProcessBase<TCommand> : ProcessBase
        where TCommand : DbCommand
    {
        public DbProcessBase(string schemaName = null)
        {
            SchemaName = string.IsNullOrWhiteSpace(schemaName) ? "dbo" : schemaName;
        }

        protected string SchemaName { get; }

        private IDbProcessor<TCommand> _processor;
        protected IDbProcessor<TCommand> Processor => ServiceStore.TryResolve(ref _processor);

        protected abstract IDbQuery GetQuery();

        protected IDbQuery ProcedureQuery(string procedureName = null)
        {
            return DbQueryFactory.Procedure(procedureName ?? GetDbObjectName());
        }

        protected string GetDbObjectName()
        {
            return $"{SchemaName}.{GetType().Name}";
        }
    }

    public abstract class DbProcessBase<TCommand, TParameters> : DbProcessBase<TCommand>
        where TCommand : DbCommand
    {
        public DbProcessBase(string schemaName = null) : base(schemaName)
        {
        }

        private TParameters _parameters;
        protected TParameters Parameters => ServiceStore.TryResolve(ref _parameters);
    }
}
