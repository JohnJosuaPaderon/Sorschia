using System.Collections.Generic;

namespace Sorschia
{
    public abstract class ModelCreatorBase<T, TModel>
        where TModel : ModelBase<T>
    {
        public ModelCreatorBase(bool allowReuse = true)
        {
            Dictionary = new Dictionary<T, TModel>();
            AllowReuse = allowReuse;
        }

        protected Dictionary<T, TModel> Dictionary { get; }
        protected abstract TModel Initialize(T source);
        protected bool AllowReuse { get; set; }

        public TModel TryCreate(T source)
        {
            if (source == null)
            {
                return null;
            }
            else if (AllowReuse)
            {
                if (Dictionary.ContainsKey(source))
                {
                    return Dictionary[source];
                }
                else
                {
                    var model = Initialize(source);
                    Dictionary.Add(source, model);
                    return model;
                }
            }
            else
            {
                return Initialize(source);
            }
        }
    }
}
