using System.Data.SqlClient;

namespace Sorschia.Data
{
    /// <summary>
    /// Managing SQL Server Database Connections
    /// </summary>
    internal sealed class SqlConnectionProvider : DbConnectionProviderBase<SqlConnection>, IDbConnectionProvider<SqlConnection>
    {
        public SqlConnectionProvider(IConnectionStringPool connectionStringPool) : base(connectionStringPool)
        {
        }

        protected override SqlConnection Instantiate()
        {
            return new SqlConnection();
        }
    }
}
