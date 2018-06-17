using Prism.Commands;
using Prism.Events;
using Prism.Interactivity.InteractionRequest;
using Prism.Regions;
using Sorschia.Events;
using System;

namespace Sorschia
{
    public abstract class PopupViewModelBase<TNotification> : ViewModelBase, IInteractionRequestAware
        where TNotification : NotificationBase, INotification
    {
        public PopupViewModelBase(IEventAggregator eventAggregator) : base(eventAggregator)
        {
            PopupStateEvent = eventAggregator.GetEvent<PopupStateEvent>();
            CloseCommand = new DelegateCommand(Close);
            CancelCommand = new DelegateCommand(Cancel);
        }

        public Action FinishInteraction { get; set; }
        public PopupStateEvent PopupStateEvent { get; }
        public DelegateCommand CloseCommand { get; }
        public DelegateCommand CancelCommand { get; }

        private TNotification _Notification;

        public INotification Notification
        {
            get { return _Notification; }
            set
            {
                SetProperty(ref _Notification, (TNotification)value, () => Content = value.Content);
            }
        }

        public object Content
        {
            get { return _Notification?.Content; }
            set
            {
                if (Notification != null)
                {
                    Notification.Content = value;
                    RaisePropertyChanged();
                }
            }
        }

        public TNotification PopupNotification
        {
            get { return _Notification; }
            set
            {
                SetProperty(ref _Notification, value, () => Content = value.Content);
            }
        }

        protected virtual void Close()
        {
            FinishInteraction?.Invoke();
        }

        private void Cancel()
        {
            PopupNotification.Result = NotificationResult.Cancelled;
            Close();
        }

        protected override void Load()
        {
            PopupStateEvent.Open();
        }

        protected override void Unload()
        {
            PopupStateEvent.Close();
        }
    }

    public abstract class NavigationViewModelBase : ViewModelBase, INavigationAware
    {
        public NavigationViewModelBase(IEventAggregator eventAggregator, IRegionManager regionManager) : base(eventAggregator)
        {
            RegionManager = regionManager;
            WindowBusyEvent = eventAggregator.GetEvent<WindowBusyEvent>();
            MessageDisplayEvent = eventAggregator.GetEvent<MessageDisplayEvent>();
            NavigateCommand = new DelegateCommand<NavigationInfo>(Navigate);
        }

        protected IRegionManager RegionManager { get; }
        protected WindowBusyEvent WindowBusyEvent { get; }
        protected MessageDisplayEvent MessageDisplayEvent { get; }
        public DelegateCommand<NavigationInfo> NavigateCommand { get; }

        public virtual bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public virtual void OnNavigatedFrom(NavigationContext navigationContext)
        {
        }

        public virtual void OnNavigatedTo(NavigationContext navigationContext)
        {
        }

        private void Navigate(NavigationInfo info)
        {
            RegionManager.RequestNavigate(info.RegionName, info.TargetViewName);
        }
    }
}
