using Sorschia.Process;
using System.Security;

namespace Sorschia.Data
{
    internal sealed class ConnectionStringPoolValidator
    {
        public void ValidateContext(IProcessContext context)
        {
            if (context == null)
            {
                throw new ProcessContextException("Process context is null.");
            }
        }

        public void ValidateConnectionString(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new ConnectionStringException("Connection string is null or white space.");
            }
        }

        public void ValidateConnectionString(SecureString secureConnectionString)
        {
            if (secureConnectionString == null)
            {
                throw new ConnectionStringException("Connection string is null.");
            }
        }
    }
}
