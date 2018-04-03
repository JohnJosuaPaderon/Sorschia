using System.Collections.Generic;

namespace Sorschia.Process
{
    internal sealed class ProcessContextTransactionManager : IProcessContextTransactionManager
    {
        public ProcessContextTransactionManager()
        {
            Source = new Dictionary<IProcessContext, bool>();
        }

        private Dictionary<IProcessContext, bool> Source { get; }
        
        private void Finalize(IProcessContext context)
        {
            if (Source.ContainsKey(context))
            {
                Source.Remove(context);
            }
        }

        public void Disable(IProcessContext context)
        {
            if (!Source.ContainsKey(context))
            {
                Source.Add(context, false);
                ProcessContext.TryAddFinalizer(context, Finalize);
            }
            else
            {
                Source[context] = false;
            }
        }

        public void Enable(IProcessContext context)
        {
            if (!Source.ContainsKey(context))
            {
                Source.Add(context, true);
                ProcessContext.TryAddFinalizer(context, Finalize);
            }
            else
            {
                Source[context] = true;
            }
        }

        public bool IsEnabled(IProcessContext context)
        {
            if (Source.ContainsKey(context))
            {
                return Source[context];
            }
            else
            {
                return true;
            }
        }
    }
}
