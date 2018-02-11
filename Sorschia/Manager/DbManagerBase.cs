using Sorschia.Data;
using Sorschia.Process;
using System.Security;

namespace Sorschia.Manager
{
    public abstract class DbManagerBase
    {
        public DbManagerBase(IProcessContextManager contextManager, IConnectionStringPool connectionStringPool)
        {
            _ContextManager = contextManager;
            _ConnectionStringPool = connectionStringPool;
        }

        private readonly IConnectionStringPool _ConnectionStringPool;
        private readonly IProcessContextManager _ContextManager;

        protected IProcessContext InitializeContext(SecureString secureConnectionString)
        {
            var context = _ContextManager.Initialize();
            _ConnectionStringPool.Add(context, secureConnectionString);
            return context;
        }
    }
}
