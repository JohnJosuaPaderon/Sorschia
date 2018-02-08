using System.Collections;
using System.Collections.Generic;

namespace Sorschia.Data
{
    internal sealed class DbQueryParameterCollection : IDbQueryParameterCollection
    {
        public DbQueryParameterCollection()
        {
            _Source = new Dictionary<string, IDbQueryParameter>();
            _Validator = new DbQueryParameterCollectionValidator();
        }

        private readonly Dictionary<string, IDbQueryParameter> _Source;
        private readonly DbQueryParameterCollectionValidator _Validator;

        public IDbQueryParameter this[string name]
        {
            get
            {
                _Validator.ValidateParameterName(name);

                if (_Source.ContainsKey(name))
                {
                    return _Source[name];
                }
                else
                {
                    return null;
                }
            }
        }

        private void UnsafeAdd(IDbQueryParameter parameter)
        {
            if (!_Source.ContainsKey(parameter.Name))
            {
                _Source.Add(parameter.Name, parameter);
            }
        }

        public void Add(IDbQueryParameter parameter)
        {
            _Validator.ValidateParameter(parameter);
            _Validator.ValidateParameterName(parameter.Name);
            UnsafeAdd(parameter);
        }

        public void Clear()
        {
            _Source.Clear();
        }

        public IEnumerator<IDbQueryParameter> GetEnumerator()
        {
            return _Source.Values.GetEnumerator();
        }

        public void Remove(IDbQueryParameter parameter)
        {
            _Validator.ValidateParameter(parameter);
            _Validator.ValidateParameterName(parameter.Name);

            if (_Source.ContainsKey(parameter.Name))
            {
                _Source.Remove(parameter.Name);
            }
        }

        public void Remove(string name)
        {
            _Validator.ValidateParameterName(name);

            if (_Source.ContainsKey(name))
            {
                _Source.Remove(name);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _Source.Values.GetEnumerator();
        }
    }
}
