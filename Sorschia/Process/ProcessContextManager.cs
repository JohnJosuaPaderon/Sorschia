using System;
using System.Collections.Generic;
using System.Linq;

namespace Sorschia.Process
{
    internal sealed class ProcessContextManager : IProcessContextManager
    {
        public ProcessContextManager()
        {
            _ContextExceptions = new Dictionary<IProcessContext, List<Exception>>();
        }

        private readonly Dictionary<IProcessContext, List<Exception>> _ContextExceptions;
        
        public void CatchException(IProcessContext context, Exception exception)
        {
            if (context is ProcessContext concrete)
            {
                if (!_ContextExceptions.ContainsKey(context))
                {
                    _ContextExceptions.Add(context, new List<Exception>());
                }

                _ContextExceptions[context].Add(exception);

                concrete.Status = ProcessContextStatus.Faulted;
            }
        }

        public void Finalize(IProcessContext context)
        {
            if (context is ProcessContext concrete)
            {
                if (concrete.Finalizers.Any())
                {
                    foreach (var finalizer in concrete.Finalizers)
                    {
                        finalizer(context);
                    }

                    concrete.Finalizers.Clear();
                }

                concrete.Status = ProcessContextStatus.Finished;
            }
            else
            {
                throw new ProcessContextException("Can't finalize process context.");
            }
        }

        public IProcessContext Initialize()
        {
            var context = new ProcessContext(this);
            context.Status = ProcessContextStatus.Initialized;
            return context;
        }
    }
}
