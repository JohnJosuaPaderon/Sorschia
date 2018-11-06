using System;

namespace Sorschia
{
    public class DatabaseQuery : IDisposable
    {
        public DatabaseQuery(IProcessContext context)
        {
            Context = context;
        }

        private IProcessContext Context { get; }

        public void Dispose()
        {
            Context.Dispose();
        }
    }
}
