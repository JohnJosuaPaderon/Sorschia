using Sorschia.Data;
using System.Data.Common;

namespace Sorschia.Process
{
    public abstract class DbProcessBase<TCommand> : ProcessBase
        where TCommand : DbCommand
    {
        public DbProcessBase(IProcessContextManager contextManager, IDbProcessor<TCommand> processor, string schema = null) : base(contextManager)
        {
            _Schema = schema;
            _Processor = processor;
        }

        protected readonly string _Schema;
        protected readonly IDbProcessor<TCommand> _Processor;

        protected abstract IDbQuery ConstructQuery();

        protected string GetDbObjectName()
        {
            if (string.IsNullOrWhiteSpace(_Schema))
            {
                return GetType().Name;
            }
            else
            {
                return $"{_Schema}.{GetType().Name}";
            }
        }
    }
}
