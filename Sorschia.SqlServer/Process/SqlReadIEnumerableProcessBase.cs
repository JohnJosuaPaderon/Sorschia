using Sorschia.Converter;
using System.Data.SqlClient;

namespace Sorschia.Process
{
    public abstract class SqlReadIEnumerableProcessBase<T, TConverter> : DbReadIEnumerableProcessBase<SqlCommand, T, TConverter>
        where TConverter : IDataConverter<T>
    {
        public SqlReadIEnumerableProcessBase(string schemaName = null) : base(schemaName)
        {
        }
    }

    public abstract class SqlReadIEnumerableProcessBase<T, TConverter, TParameters> : DbReadIEnumerableProcessBase<SqlCommand, T, TConverter, TParameters>
        where TConverter : IDataConverter<T>
    {
        public SqlReadIEnumerableProcessBase(string schemaName = null) : base(schemaName)
        {
        }
    }
}
