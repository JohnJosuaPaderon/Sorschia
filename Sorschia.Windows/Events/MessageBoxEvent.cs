using Prism.Events;
using Sorschia.Models;
using System;
using System.Windows;

namespace Sorschia.Events
{
    public sealed class MessageBoxEvent : PubSubEvent<MMessageBox>
    {
        public void Raise(string message, string header = null, MessageBoxButton button = MessageBoxButton.OK, MessageBoxImage image = MessageBoxImage.None, Action<MessageBoxResult> resultCallback = null)
        {
            Publish(new MMessageBox(message, header, button, image, resultCallback));
        }
    }
}
