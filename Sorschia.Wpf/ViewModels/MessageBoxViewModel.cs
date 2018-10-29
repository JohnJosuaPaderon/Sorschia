using Prism.Events;

namespace Sorschia.ViewModels
{
    public sealed class MessageBoxViewModel : MessageBoxViewModelBase
    {
        public MessageBoxViewModel(IEventAggregator eventAggregator) : base(eventAggregator)
        {
        }
    }
}
