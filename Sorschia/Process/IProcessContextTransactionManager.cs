namespace Sorschia
{
    public interface IProcessContextTransactionManager
    {
        void Enable(IProcessContext context);
        void Disable(IProcessContext context);
        bool IsEnabled(IProcessContext context);
    }
}
