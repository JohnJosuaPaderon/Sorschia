namespace Sorschia.Process
{
    public abstract class ProcessCoreBase
    {
        public ProcessCoreBase(IProcessContextManager contextManager)
        {
            ContextManager = contextManager;
        }

        protected IProcessContextManager ContextManager { get; }

        public virtual void Dispose()
        {
            // TODO: Release resources
        }
    }
}
