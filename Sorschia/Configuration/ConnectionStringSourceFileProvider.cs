namespace Sorschia.Configuration
{
    public sealed class ConnectionStringSourceFileProvider : IConnectionStringSourceFileProvider
    {
        public ConnectionStringSourceFileProvider(string path)
        {
            Validator.NullOrWhiteSpace(path, "Invalid connection string source file path.");
            Path = path;
        }

        public string Path { get; }
    }
}
