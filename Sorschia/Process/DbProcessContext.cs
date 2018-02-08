using System.Security;

namespace Sorschia.Process
{
    /// <summary>
    /// Implementation of <see cref="IProcessContext"/> for database processes
    /// </summary>
    internal sealed class DbProcessContext : ProcessContextBase, IProcessContext
    {
        /// <summary>
        /// Secure connection string used by processes
        /// </summary>
        public SecureString SecureConnectionString { get; set; }

        public override void Dispose()
        {
            SecureConnectionString.Dispose();
            base.Dispose();
        }
    }
}
