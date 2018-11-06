using Prism.Events;
using Prism.Interactivity.InteractionRequest;
using Prism.Regions;
using Sorschia.Events;
using Sorschia.Models;

namespace Sorschia.ViewModels
{
    public sealed class MainWindowViewModel : NavigationViewModelBase
    {
        public MainWindowViewModel(IEventAggregator eventAggregator, IRegionManager regionManager) : base(eventAggregator, regionManager)
        {
            MessageBoxRequest = new InteractionRequest<MessageBoxNotification>();
            PopupStateEvent = eventAggregator.GetEvent<PopupStateEvent>();
            WindowBusyEvent.Subscribe(WindowBusyEventRaised);
            PopupStateEvent.Subscribe(PopupStateEventRaised);
            MessageBoxEvent.Subscribe(MessageBoxEventRaised);
        }

        private IConfigurationProvider _configurationProvider;
        private IConfigurationProvider ConfigurationProvider => ServiceStore.TryResolve(ref _configurationProvider);

        public InteractionRequest<MessageBoxNotification> MessageBoxRequest { get; }
        public PopupStateEvent PopupStateEvent { get; }
        
        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private string _windowState;
        public string WindowState
        {
            get { return _windowState; }
            set { SetProperty(ref _windowState, value); }
        }

        private int? _titlebarHeight;
        public int? TitlebarHeight
        {
            get { return _titlebarHeight; }
            set { SetProperty(ref _titlebarHeight, value); }
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
            Title = ConfigurationProvider.GetString("sorschia:MainWindow.Title") ?? string.Empty;
            WindowState = ConfigurationProvider.GetString("sorschia:MainWindow.WindowState") ?? "Normal";
            TitlebarHeight = ConfigurationProvider.GetNullableInt32("sorschia:MainWindow.TitlebarHeight");
        }

        protected override void Load()
        {
            LoadConfigValues();
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
