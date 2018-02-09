namespace Sorschia.Process
{
    public abstract class ProcessBase : ProcessCoreBase
    {
        public ProcessBase(IProcessContextManager contextManager) : base(contextManager)
        {
        }
    }

    public abstract class ProcessBase<T> : ProcessCoreBase
    {
        public ProcessBase(IProcessContextManager contextManager) : base(contextManager)
        {
        }
    }
}
