using System;

namespace Sorschia.Data
{
    public static class DbQueryFactory
    {
        public static IDbQuery Procedure(string procedureName)
        {
            if (string.IsNullOrWhiteSpace(procedureName))
            {
                throw new ArgumentException("Procedure name cannot be null or white space.", nameof(procedureName));
            }
            else
            {
                return new ProcedureQuery
                {
                    Command = procedureName
                };
            }
        }

        public static IDbQuery Text(string query)
        {
            if (string.IsNullOrWhiteSpace(query))
            {
                throw new ArgumentException("Query cannot be null or white space.", nameof(query));
            }
            else
            {
                return new TextQuery
                {
                    Command = query
                };
            }
        }
    }
}
