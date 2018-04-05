using Prism.Mvvm;

namespace Sorschia
{
    public abstract class NotificationBase : BindableBase
    {
        public NotificationBase()
        {
            Title = string.Empty;
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

        private NotificationResult _Result;
        public NotificationResult Result
        {
            get { return _Result; }
            set { SetProperty(ref _Result, value); }
        }
    }
}
