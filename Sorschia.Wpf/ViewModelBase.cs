using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using System;

namespace Sorschia
{
    public abstract class ViewModelBase : BindableBase
    {
        public ViewModelBase(IEventAggregator eventAggregator)
        {
            EventAggregator = eventAggregator;
            LoadCommand = new DelegateCommand(Load);
            UnloadCommand = new DelegateCommand(Unload);
        }

        protected IEventAggregator EventAggregator { get; }
        public DelegateCommand LoadCommand { get; }
        public DelegateCommand UnloadCommand { get; }

        protected virtual void Load()
        {
            throw new NotImplementedException("View is binded to LoadCommand but not overriden the Load();");
        }

        protected virtual void Unload()
        {
            throw new NotImplementedException("View is binded to UnloadCommand but not overriden the Unload();");
        }
    }
}
