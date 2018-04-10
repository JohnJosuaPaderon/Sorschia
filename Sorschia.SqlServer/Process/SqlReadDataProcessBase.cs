using Sorschia.Converter;
using Sorschia.Data;
using System.Data.SqlClient;

namespace Sorschia.Process
{
    public abstract class SqlReadDataProcessBase<T, TConverter> : ReadDataProcessBase<T, SqlCommand, TConverter>
        where TConverter : IDataConverter<T>
    {
        public SqlReadDataProcessBase(IProcessContextManager contextManager, IDbProcessor<SqlCommand> processor, TConverter converter, string schema = null) : base(contextManager, processor, converter, schema)
        {
        }
    }

    public abstract class SqlReadDataProcessBase<T, TConverter, TParameters> : ReadDataProcessBase<T, SqlCommand, TConverter, TParameters>
        where TConverter : IDataConverter<T>
    {
        public SqlReadDataProcessBase(IProcessContextManager contextManager, IDbProcessor<SqlCommand> processor, TConverter converter, TParameters parameters, string schema = null) : base(contextManager, processor, converter, parameters, schema)
        {
        }
    }
}
