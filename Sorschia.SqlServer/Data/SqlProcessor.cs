using System.Data.SqlClient;

namespace Sorschia
{
    internal sealed class SqlProcessor : DbProcessorBase<SqlCommand>, IDbProcessor<SqlCommand>
    {
        public SqlProcessor(IProcessContextManager contextManager, IDbCommandCreator<SqlCommand> commandCreator) : base(contextManager, commandCreator)
        {
        }
    }
}
