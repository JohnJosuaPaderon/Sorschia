using Sorschia.Data;
using System.Data.Common;

namespace Sorschia.Process
{
    public abstract class DbProcessBase<TCommand> : ProcessBase
        where TCommand : DbCommand
    {
        public DbProcessBase(IProcessContextManager contextManager, IDbProcessor<TCommand> processor, string schema = null) : base(contextManager)
        {
            Schema = schema;
            Processor = processor;
        }

        protected string Schema { get; }
        protected IDbProcessor<TCommand> Processor { get; }

        protected abstract IDbQuery ConstructQuery();

        protected IDbQuery ProcedureQuery(string procedureName = null)
        {
            return DbQueryFactory.Procedure(procedureName ?? GetDbObjectName());
        }

        protected string GetDbObjectName()
        {
            if (string.IsNullOrWhiteSpace(Schema))
            {
                return GetType().Name;
            }
            else
            {
                return $"{Schema}.{GetType().Name}";
            }
        }
    }
}
