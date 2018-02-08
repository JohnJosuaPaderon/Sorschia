namespace Sorschia.Process
{
    /// <summary>
    /// Implementation of <see cref="IProcessContextFactory"/> for database processes
    /// </summary>
    internal sealed class DbProcessContextFactory : ProcessContextFactoryBase, IProcessContextFactory
    {
        protected override IProcessContext Construct()
        {
            return new DbProcessContext();
        }
    }
}
