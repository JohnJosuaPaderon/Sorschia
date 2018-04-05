using Prism.Commands;
using Prism.Events;
using Prism.Regions;

namespace Sorschia
{
    public abstract class NavigationViewModelBase : ViewModelBase, INavigationAware
    {
        public NavigationViewModelBase(IEventAggregator eventAggregator, IRegionManager regionManager) : base(eventAggregator)
        {
            RegionManager = regionManager;
            NavigateCommand = new DelegateCommand<string>(Navigate);
        }

        protected IRegionManager RegionManager { get; }
        public DelegateCommand<string> NavigateCommand { get; }
        protected string MainNavigationRegion { get; set; }

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

        protected void Navigate(string viewName)
        {
            Validator.NullOrWhiteSpace(MainNavigationRegion, "MainNavigationRegion is not set.");
            Validator.NullOrWhiteSpace(viewName, "Invalid view name.");
            RegionManager.RequestNavigate(MainNavigationRegion, viewName);
        }

        protected void Navigate(string viewName, NavigationParameters parameters)
        {
            Validator.NullOrWhiteSpace(MainNavigationRegion, "MainNavigationRegion is not set.");
            Validator.NullOrWhiteSpace(viewName, "Invalid view name.");
            Validator.Null(parameters, "Invalid parameters");
            Validator.EmptyIEnumerable(parameters, "No navigation parameters supplied.");
            RegionManager.RequestNavigate(MainNavigationRegion, viewName, parameters);
        }

        protected void Navigate(string regionName, string viewName)
        {
            Validator.NullOrWhiteSpace(regionName, "Invalid region name.");
            Validator.NullOrWhiteSpace(viewName, "Invalid view name.");
            RegionManager.RequestNavigate(regionName, viewName);
        }

        protected void Navigate(string regionName, string viewName, NavigationParameters parameters)
        {
            Validator.NullOrWhiteSpace(regionName, "Invalid region name.");
            Validator.NullOrWhiteSpace(viewName, "Invalid view name.");
            Validator.Null(parameters, "Invalid parameters");
            Validator.EmptyIEnumerable(parameters, "No navigation parameters supplied.");
            RegionManager.RequestNavigate(regionName, viewName, parameters);
        }
    }
}
