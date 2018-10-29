using Prism.Mvvm;
using System;
using System.Windows;

namespace Sorschia.Models
{
    public sealed class MMessageBox : BindableBase
    {
        public MMessageBox(string message, string header = null, MessageBoxButton button = MessageBoxButton.OK, MessageBoxImage image = MessageBoxImage.None, Action<MessageBoxResult> resultCallback = null)
        {
            Header = header;
            Message = message;
            Button = button;
            Image = image;
            ResultCallback = resultCallback;
        }

        public string Header { get; }
        public string Message { get; }
        public MessageBoxButton Button { get; }
        public MessageBoxImage Image { get; }
        public Action<MessageBoxResult> ResultCallback { get; }
    }
}
