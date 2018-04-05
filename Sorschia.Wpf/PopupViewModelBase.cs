using Prism.Commands;
using Prism.Events;
using Prism.Interactivity.InteractionRequest;
using System;

namespace Sorschia
{
    public abstract class PopupViewModelBase<TNotification> : ViewModelBase, IInteractionRequestAware
        where TNotification : NotificationBase, INotification
    {
        public PopupViewModelBase(IEventAggregator eventAggregator) : base(eventAggregator)
        {
            PopupNotification.Result = NotificationResult.NotSet;
            CancelCommand = new DelegateCommand(Cancel);
        }

        public Action FinishInteraction { get; set; }
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

        protected TNotification PopupNotification
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

        protected void Cancel()
        {
            PopupNotification.Result = NotificationResult.Cancelled;
            Close();
        }
    }
}
