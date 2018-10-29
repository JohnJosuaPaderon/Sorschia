using Prism.Interactivity.InteractionRequest;
using Sorschia.Models;
using System.Windows;

namespace Sorschia.ViewModels
{
    public sealed class MessageBoxNotification : NotificationBase, INotification
    {
        public MessageBoxNotification(MMessageBox model)
        {
            Validator.Null(model, "Invalid message box model.");
            Model = model;
        }

        public MMessageBox Model { get; }
        public MessageBoxResult MessageBoxResult { get; set; }
    }
}
