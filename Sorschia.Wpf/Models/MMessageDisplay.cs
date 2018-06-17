namespace Sorschia.Models
{
    public sealed class MMessageDisplay
    {
        public MMessageDisplay(string message)
        {
            Message = message;
        }

        public MMessageDisplay(string header, string message)
        {
            Header = header;
            Message = message;
        }

        public string Header { get; }
        public string Message { get; }
    }
}
