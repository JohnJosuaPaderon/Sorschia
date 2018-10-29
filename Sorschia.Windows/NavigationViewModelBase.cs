using Prism.Commands;
using Prism.Events;
using Prism.Regions;
using Sorschia.Events;

namespace Sorschia
{
    public abstract class NavigationViewModelBase : ViewModelBase, INavigationAware
    {
        public NavigationViewModelBase(IEventAggregator eventAggregator, IRegionManager regionManager) : base(eventAggregator)
        {
            RegionManager = regionManager;
            WindowBusyEvent = eventAggregator.GetEvent<WindowBusyEvent>();
            MessageBoxEvent = eventAggregator.GetEvent<MessageBoxEvent>();
            NavigateCommand = new DelegateCommand<NavigationInfo>(Navigate);
        }

        protected IRegionManager RegionManager { get; }
        protected WindowBusyEvent WindowBusyEvent { get; }
        protected MessageBoxEvent MessageBoxEvent { get; }
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
