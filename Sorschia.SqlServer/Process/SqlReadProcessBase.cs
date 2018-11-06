using System.Data.SqlClient;

namespace Sorschia
{
    public abstract class SqlReadProcessBase<T, TConverter> : DbReadProcessBase<SqlCommand, T, TConverter>
        where TConverter : IDataConverter<T>
    {
        public SqlReadProcessBase(string schemaName = null) : base(schemaName)
        {
        }
    }

    public abstract class SqlReadProcessBase<T, TConverter, TParameters> : DbReadProcessBase<SqlCommand, T, TConverter, TParameters>
        where TConverter : IDataConverter<T>
    {
        public SqlReadProcessBase(string schemaName = null) : base(schemaName)
        {
        }
    }
}
