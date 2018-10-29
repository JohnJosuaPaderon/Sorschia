using Prism.Commands;
using Prism.Events;
using System;
using System.Windows;

namespace Sorschia.ViewModels
{
    public abstract class MessageBoxViewModelBase : PopupViewModelBase<MessageBoxNotification>
    {
        public MessageBoxViewModelBase(IEventAggregator eventAggregator) : base(eventAggregator)
        {
            SubmitCommand = new DelegateCommand<string>(Submit);
        }

        public DelegateCommand<string> SubmitCommand { get; }

        private string _header;
        public string Header
        {
            get { return _header; }
            set { SetProperty(ref _header, value); }
        }

        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        private MessageBoxButton _button;
        public MessageBoxButton Button
        {
            get { return _button; }
            set { SetProperty(ref _button, value); }
        }

        private MessageBoxImage _image;
        public MessageBoxImage Image
        {
            get { return _image; }
            set { SetProperty(ref _image, value); }
        }

        protected override void Load()
        {
            base.Load();
            Header = PopupNotification.Model.Header;
            Message = PopupNotification.Model.Message;
            Button = PopupNotification.Model.Button;
            Image = PopupNotification.Model.Image;
        }

        private void Submit(string param)
        {
            var messageResult = MessageBoxResult.None;
            if (Enum.TryParse(param, out MessageBoxResult result))
            {
                messageResult = result;
            }
            PopupNotification.Model.ResultCallback?.Invoke(messageResult);
            Close();
        }
    }
}
