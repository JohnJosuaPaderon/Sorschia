using System;
using System.Threading;
using System.Threading.Tasks;

namespace Sorschia
{
    public interface IProcess : IDisposable
    {
        void Execute(IProcessContext context);
        Task ExecuteAsync(IProcessContext context);
        Task ExecuteAsync(IProcessContext context, CancellationToken cancellationToken);
    }

    public interface IProcess<T> : IDisposable
    {
        T Execute(IProcessContext context);
        Task<T> ExecuteAsync(IProcessContext context);
        Task<T> ExecuteAsync(IProcessContext context, CancellationToken cancellationToken);
    }
}
