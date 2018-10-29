using Prism.Events;
using Prism.Interactivity.InteractionRequest;
using Prism.Regions;
using Sorschia.Events;
using Sorschia.Models;
using System.Windows;

namespace Sorschia.ViewModels
{
    public class MainWindowViewModel : NavigationViewModelBase
    {
        public MainWindowViewModel(IEventAggregator eventAggregator, IRegionManager regionManager) : base(eventAggregator, regionManager)
        {
            MessageBoxRequest = new InteractionRequest<MessageBoxNotification>();
            PopupStateEvent = eventAggregator.GetEvent<PopupStateEvent>();
            WindowBusyEvent.Subscribe(WindowBusyEventRaised);
            PopupStateEvent.Subscribe(PopupStateEventRaised);
            MessageBoxEvent.Subscribe(MessageBoxEventRaised);
        }

        public InteractionRequest<MessageBoxNotification> MessageBoxRequest { get; }
        public PopupStateEvent PopupStateEvent { get; }

        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private bool _isWindowBusy;
        public bool IsWindowBusy
        {
            get { return _isWindowBusy; }
            set { SetProperty(ref _isWindowBusy, value, IsUiBlockedChanged); }
        }

        private bool _isPopupOpen;
        public bool IsPopupOpen
        {
            get { return _isPopupOpen; }
            set { SetProperty(ref _isPopupOpen, value, IsUiBlockedChanged); }
        }

        public bool IsUiBlocked => IsWindowBusy || IsPopupOpen;

        private void IsUiBlockedChanged()
        {
            RaisePropertyChanged(nameof(IsUiBlocked));
        }

        private void LoadConfigValues()
        {
            Title = "Sorschia";
        }

        protected override void Load()
        {
            LoadConfigValues();
            MessageBoxEvent.Raise("We display message on purpose", button: MessageBoxButton.YesNoCancel, image: MessageBoxImage.Error);
        }

        private void MessageBoxEventRaised(MMessageBox payload)
        {
            MessageBoxRequest.Raise(new MessageBoxNotification(payload));
        }

        private void PopupStateEventRaised(bool payload)
        {
            IsPopupOpen = payload;
        }

        private void WindowBusyEventRaised(bool payload)
        {
            IsWindowBusy = payload;
        }
    }
}
