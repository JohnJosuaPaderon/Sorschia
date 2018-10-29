using Prism.Mvvm;

namespace Sorschia
{
    public abstract class ModelBase<T> : BindableBase
    {
        public ModelBase(T source)
        {
            Source = source;
        }

        public T Source { get; }

        public virtual T GetUpdatedSource()
        {
            return Source;
        }
    }
}
