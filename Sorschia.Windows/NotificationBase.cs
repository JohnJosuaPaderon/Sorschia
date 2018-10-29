using Prism.Interactivity.InteractionRequest;
using Prism.Mvvm;

namespace Sorschia
{
    public abstract class NotificationBase : BindableBase, INotification
    {
        public NotificationBase() : this(NotificationVerb.NotSet)
        {
        }

        public NotificationBase(NotificationVerb verb)
        {
            Title = string.Empty;
            Verb = verb;
        }

        private string _Title;
        public string Title
        {
            get { return _Title; }
            set { SetProperty(ref _Title, value); }
        }

        private object _Content;
        public object Content
        {
            get { return _Content; }
            set { SetProperty(ref _Content, value); }
        }

        public NotificationResult Result { get; set; }
        public NotificationVerb Verb { get; }
    }
}
