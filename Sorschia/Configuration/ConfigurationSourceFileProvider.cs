namespace Sorschia
{
    public sealed class ConfigurationSourceFileProvider : IConfigurationSourceFileProvider
    {
        public ConfigurationSourceFileProvider(string path)
        {
            Validator.NullOrWhiteSpace(path, "Invalid configuration file path.");
            Path = path;
        }

        public string Path { get; }
    }
}
