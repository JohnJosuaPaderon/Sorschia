using Sorschia.Process;
using System.Data.Common;

namespace Sorschia.Data
{
    /// <summary>
    /// Manages database transactions
    /// </summary>
    public interface IDbTransactionProvider<T> where T : DbTransaction
    {
        /// <summary>
        /// Dispose the database transaction related to the specified process context
        /// </summary>
        void Finalize(IProcessContext context);

        /// <summary>
        /// Gets the database connection using the specified process context
        /// </summary>
        T Get(IProcessContext context);
    }
}
