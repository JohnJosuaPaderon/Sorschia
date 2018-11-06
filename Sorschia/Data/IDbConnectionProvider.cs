using System.Data.Common;
using System.Threading;
using System.Threading.Tasks;

namespace Sorschia
{
    /// <summary>
    /// Manages database connections
    /// </summary>
    public interface IDbConnectionProvider<T> where T : DbConnection
    {
        /// <summary>
        /// Close and dispose the database connection related to the specified <see cref="IProcessContext"/>
        /// </summary>
        void Finalize(IProcessContext context);

        /// <summary>
        /// Gets an open database connection using the specified process context
        /// </summary>
        T Get(IProcessContext context);

        /// <summary>
        /// Gets an open database connection asynchronously using the specified process context
        /// </summary>
        Task<T> GetAsync(IProcessContext context);

        /// <summary>
        /// Gets an open connection asynchronously using the specified process context
        /// </summary>
        Task<T> GetAsync(IProcessContext context, CancellationToken cancellationToken);
    }
}
