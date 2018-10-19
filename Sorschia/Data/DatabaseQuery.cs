using Sorschia.Process;
using System;

namespace Sorschia.Data
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
