using System.Collections.Generic;
using System.Security;

namespace Sorschia
{
    internal sealed class ConnectionStringPool : IConnectionStringPool
    {
        public ConnectionStringPool()
        {
            _Source = new Dictionary<IProcessContext, SecureString>();
        }

        private readonly Dictionary<IProcessContext, SecureString> _Source;

        private void UnsafeAdd(IProcessContext context, SecureString secureConnectionString)
        {
            if (!_Source.ContainsKey(context))
            {
                _Source.Add(context, secureConnectionString);
                ProcessContext.TryAddFinalizer(context, Finalize);
            }
        }

        public void Add(IProcessContext context, string connectionString)
        {
            Validator.Null(context, "Invalid process context.");
            Validator.NullOrWhiteSpace(connectionString, "Invalid connection string.");
            UnsafeAdd(context, SecureStringConverter.Convert(connectionString));
        }

        public void Add(IProcessContext context, SecureString secureConnectionString)
        {
            Validator.Null(context, "Invalid process context.");
            Validator.Null(secureConnectionString, "Invalid secure connection string.");
            UnsafeAdd(context, secureConnectionString);
        }

        public SecureString Get(IProcessContext context)
        {
            Validator.Null(context, "Invalid process context.");
            if (_Source.ContainsKey(context))
            {
                return _Source[context];
            }
            else
            {
                return null;
            }
        }

        public void Finalize(IProcessContext context)
        {
            Validator.Null(context, "Invalid process context.");
            if (_Source.ContainsKey(context))
            {
                var secureConnectionString = _Source[context];
                _Source.Remove(context);
            }
        }
    }
}
