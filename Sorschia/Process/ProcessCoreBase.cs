namespace Sorschia.Process
{
    public abstract class ProcessCoreBase
    {
        public ProcessCoreBase(IProcessContextManager contextManager)
        {
            _ContextManager = contextManager;
        }

        protected readonly IProcessContextManager _ContextManager;

        public virtual void Dispose()
        {
            // TODO: Release resources
        }
    }
}
