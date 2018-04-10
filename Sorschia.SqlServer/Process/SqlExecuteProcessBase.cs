using Sorschia.Data;
using System.Data.SqlClient;

namespace Sorschia.Process
{
    public abstract class SqlExecuteProcessBase<T> : DbExecuteProcessBase<T, SqlCommand>
    {
        public SqlExecuteProcessBase(IProcessContextManager contextManager, IDbProcessor<SqlCommand> processor, string schema = null) : base(contextManager, processor, schema)
        {
        }
    }

    public abstract class SqlExecuteProcessBase<T, TParameters> : DbExecuteProcessBase<T, SqlCommand, TParameters>
    {
        public SqlExecuteProcessBase(IProcessContextManager contextManager, IDbProcessor<SqlCommand> processor, TParameters parameters, string schema = null) : base(contextManager, processor, parameters, schema)
        {
        }
    }
}
