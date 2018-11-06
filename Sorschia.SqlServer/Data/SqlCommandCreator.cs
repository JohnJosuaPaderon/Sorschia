using System.Data.SqlClient;

namespace Sorschia
{
    internal sealed class SqlCommandCreator : DbCommandCreatorBase<SqlConnection, SqlTransaction, SqlCommand, SqlParameter>, IDbCommandCreator<SqlCommand>
    {
        public SqlCommandCreator(IDbConnectionProvider<SqlConnection> connectionProvider, IDbTransactionProvider<SqlTransaction> transactionProvider, IDbQueryParameterConverter<SqlParameter> parameterConverter) : base(connectionProvider, transactionProvider, parameterConverter, (command, parameter) => command.Parameters.Add(parameter))
        {
        }

        protected override SqlCommand Construct(SqlConnection connection, SqlTransaction transaction)
        {
            return new SqlCommand()
            {
                Connection = connection,
                Transaction = transaction
            };
        }
    }
}
