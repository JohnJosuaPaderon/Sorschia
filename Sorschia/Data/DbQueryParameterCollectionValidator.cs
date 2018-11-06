using System;

namespace Sorschia
{
    internal sealed class DbQueryParameterCollectionValidator
    {
        public void ValidateParameterName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new Exception("Parameter name is invalid.");
            }
        }

        public void ValidateParameter(IDbQueryParameter parameter)
        {
            if (parameter == null)
            {
                throw new Exception("Parameter is set to null.");
            }
        }
    }
}
