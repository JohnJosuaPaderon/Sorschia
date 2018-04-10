using Sorschia.Data;
using System;
using System.Data.SqlClient;

namespace Sorschia.Process
{
    public abstract class SqlScalarProcessBase<T> : DbScalarProcessBase<T, SqlCommand>
    {
        public SqlScalarProcessBase(IProcessContextManager contextManager, IDbProcessor<SqlCommand> processor, Func<object, T> convert, string schema = null) : base(contextManager, processor, convert, schema)
        {
        }
    }

    public abstract class SqlScalarProcessBase<T, TParameters> : DbScalarProcessBase<T, TParameters, SqlCommand>
    {
        public SqlScalarProcessBase(IProcessContextManager contextManager, IDbProcessor<SqlCommand> processor, TParameters parameters, Func<object, T> convert, string schema = null) : base(contextManager, processor, parameters, convert, schema)
        {
        }
    }
}
