using System;
using System.Data.SqlClient;

namespace Sorschia
{
    public abstract class SqlScalarProcessBase<T> : DbScalarProcessBase<SqlCommand, T>
    {
        public SqlScalarProcessBase(Func<object, T> convert, string schemaName = null) : base(convert, schemaName)
        {
        }
    }

    public abstract class SqlScalarProcessBase<T, TParameters> : DbScalarProcessBase<SqlCommand, T, TParameters>
    {
        public SqlScalarProcessBase(Func<object, T> convert, string schemaName = null) : base(convert, schemaName)
        {
        }
    }
}
