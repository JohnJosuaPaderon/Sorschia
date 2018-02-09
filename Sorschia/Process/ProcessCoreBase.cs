using System;

namespace Sorschia.Process
{
    public abstract class ProcessCoreBase : IProcessCore
    {
        public ProcessCoreBase(IProcessContextManager contextManager)
        {
            _ContextManager = contextManager;
            Key = Guid.NewGuid();
        }

        protected readonly IProcessContextManager _ContextManager;

        public Guid Key { get; }

        public virtual void Dispose()
        {
            // TODO: Release resources
        }
    }
}
