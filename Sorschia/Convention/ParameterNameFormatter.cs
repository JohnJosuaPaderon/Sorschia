namespace Sorschia.Convention
{
    internal sealed class ParameterNameFormatter : IParameterNameFormatter
    {
        public string Format(string parameterName)
        {
            return $"@_{parameterName}";
        }
    }
}
