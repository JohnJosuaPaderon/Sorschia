using Sorschia.Converter;
using Sorschia.Data;
using System.Data.SqlClient;

namespace Sorschia.Process
{
    public abstract class SqlReadIEnumerableDataProcessBase<T, TConverter> : ReadIEnumerableDataProcessBase<T, SqlCommand, TConverter>
        where TConverter : IDataConverter<T>
    {
        public SqlReadIEnumerableDataProcessBase(IProcessContextManager contextManager, IDbProcessor<SqlCommand> processor, TConverter converter, string schema = null) : base(contextManager, processor, converter, schema)
        {
        }
    }

    public abstract class SqlReadIEnumerableDataProcessBase<T, TConverter, TParameters> : ReadIEnumerableDataProcessBase<T, SqlCommand, TConverter, TParameters>
        where TConverter : IDataConverter<T>
    {
        public SqlReadIEnumerableDataProcessBase(IProcessContextManager contextManager, IDbProcessor<SqlCommand> processor, TConverter converter, TParameters parameters, string schema = null) : base(contextManager, processor, converter, parameters, schema)
        {
        }
    }
}
