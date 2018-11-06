using System.Data.SqlClient;

namespace Sorschia
{
    public abstract class SqlExecuteProcessBase<T> : DbExecuteProcessBase<SqlCommand, T>
    {
        public SqlExecuteProcessBase(string schemaName = null) : base(schemaName)
        {
        }
    }

    public abstract class SqlExecuteProcessBase<T, TParameters> : DbExecuteProcessBase<SqlCommand, T, TParameters>
    {
        public SqlExecuteProcessBase(string schemaName = null) : base(schemaName)
        {
        }
    }
}
