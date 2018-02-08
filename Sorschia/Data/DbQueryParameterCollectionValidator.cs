namespace Sorschia.Data
{
    internal sealed class DbQueryParameterCollectionValidator
    {
        public void ValidateParameterName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new DbQueryParameterValidationException("Parameter name is invalid.");
            }
        }

        public void ValidateParameter(IDbQueryParameter parameter)
        {
            if (parameter == null)
            {
                throw new DbQueryParameterValidationException("Parameter is set to null.");
            }
        }
    }
}
