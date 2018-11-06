using System.Data.SqlClient;

namespace Sorschia
{
    internal sealed class SqlTransactionProvider : DbTransactionProviderBase<SqlConnection, SqlTransaction>, IDbTransactionProvider<SqlTransaction>
    {
        public SqlTransactionProvider(IDbConnectionProvider<SqlConnection> connectionProvider, IProcessContextTransactionManager contextTransactionManager) : base(connectionProvider, contextTransactionManager)
        {
        }

        protected override SqlTransaction BeginTransaction(SqlConnection connection)
        {
            return connection.BeginTransaction();
        }
    }
}
