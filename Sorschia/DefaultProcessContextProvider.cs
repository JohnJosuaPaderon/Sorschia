using Sorschia.Configuration;
using Sorschia.Data;
using Sorschia.Process;
using System.Security;

namespace Sorschia
{
    internal sealed class DefaultProcessContextProvider : IProcessContextProvider
    {
        public DefaultProcessContextProvider(IConnectionStringPool connectionStringPool, IProcessContextManager contextManager, IProcessContextTransactionManager contextTransactionManager)
        {
            ConnectionStringPool = connectionStringPool;
            ContextManager = contextManager;
            ContextTransactionManager = contextTransactionManager;
        }

        private IConnectionStringPool ConnectionStringPool { get; }
        private IProcessContextManager ContextManager { get; }
        private IProcessContextTransactionManager ContextTransactionManager { get; }
        private IConnectionStringManager ConnectionStringManager { get; }
        
        public IProcessContext Get(SecureString secureConnectionString, bool enableTransaction = false)
        {
            var context = ContextManager.Initialize();

            if (enableTransaction)
            {
                ContextTransactionManager.Enable(context);
            }
            else
            {
                ContextTransactionManager.Disable(context);
            }

            ConnectionStringPool.Add(context, secureConnectionString);
            return context;
        }


    }
}
