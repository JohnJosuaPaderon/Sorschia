using System.Threading;
using System.Threading.Tasks;

namespace Sorschia.Process
{
    public interface IProcess : IProcessCore
    {
        void Execute(IProcessContext context);
        Task ExecuteAsync(IProcessContext context);
        Task ExecuteAsync(IProcessContext context, CancellationToken cancellationToken);
    }

    public interface IProcess<T> : IProcessCore
    {
        T Execute(IProcessContext context);
        Task<T> ExecuteAsync(IProcessContext context);
        Task<T> ExecuteAsync(IProcessContext context, CancellationToken cancellationToken);
    }
}
