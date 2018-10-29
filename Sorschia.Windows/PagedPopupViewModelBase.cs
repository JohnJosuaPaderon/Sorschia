using Prism.Commands;
using Prism.Events;
using Prism.Interactivity.InteractionRequest;
using System;

namespace Sorschia
{
    public abstract class PagedPopupViewModelBase<TNotification> : PopupViewModelBase<TNotification>
        where TNotification : NotificationBase, INotification
    {
        public PagedPopupViewModelBase(IEventAggregator eventAggregator) : base(eventAggregator)
        {
            ChangePageCommand = new DelegateCommand<object>(ChangePage);
        }

        public DelegateCommand<object> ChangePageCommand { get; }

        private int _selectedPage;
        public int SelectedPage
        {
            get { return _selectedPage; }
            set { SetProperty(ref _selectedPage, value); }
        }

        protected void ChangePage(object pageIndex)
        {
            SelectedPage = Convert.ToInt32(pageIndex);
        }
    }
}
