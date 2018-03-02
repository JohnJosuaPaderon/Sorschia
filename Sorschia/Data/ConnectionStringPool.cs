using Sorschia.Process;
using Sorschia.Security;
using System.Collections.Generic;
using System.Security;

namespace Sorschia.Data
{
    internal sealed class ConnectionStringPool : IConnectionStringPool
    {
        public ConnectionStringPool()
        {
            _Source = new Dictionary<IProcessContext, SecureString>();
            _Validator = new ConnectionStringPoolValidator();
        }

        private readonly Dictionary<IProcessContext, SecureString> _Source;
        private readonly ConnectionStringPoolValidator _Validator;

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
            _Validator.ValidateContext(context);
            _Validator.ValidateConnectionString(connectionString);
            UnsafeAdd(context, SecureStringConverter.Convert(connectionString));
        }

        public void Add(IProcessContext context, SecureString secureConnectionString)
        {
            _Validator.ValidateContext(context);
            _Validator.ValidateConnectionString(secureConnectionString);
            UnsafeAdd(context, secureConnectionString);
        }

        public SecureString Get(IProcessContext context)
        {
            _Validator.ValidateContext(context);

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
            _Validator.ValidateContext(context);

            if (_Source.ContainsKey(context))
            {
                var secureConnectionString = _Source[context];
                _Source.Remove(context);
            }
        }
    }
}
