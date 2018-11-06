using System;

namespace Sorschia
{
    public abstract class ProcessBase : IDisposable
    {
        private IProcessContextManager _contextManager;
        protected IProcessContextManager ContextManager => ServiceStore.TryResolve(ref _contextManager);

        public virtual void Dispose()
        {
            //TODO: Release resources
        }
    }
}
