﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Sorschia
{
    internal sealed class ProcessContextManager : IProcessContextManager
    {
        public ProcessContextManager()
        {
            ContextExceptions = new Dictionary<IProcessContext, List<Exception>>();
        }

        private Dictionary<IProcessContext, List<Exception>> ContextExceptions { get; }
        
        public void CatchException(IProcessContext context, Exception exception)
        {
            if (context is ProcessContext concrete)
            {
                if (!ContextExceptions.ContainsKey(context))
                {
                    ContextExceptions.Add(context, new List<Exception>());
                }

                ContextExceptions[context].Add(exception);

                concrete.Status = ProcessContextStatus.Faulted;

                if (context.ThrowExceptions)
                {
                    throw new Exception("See innerException", exception);
                }
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
                throw new Exception("Can't finalize process context.");
            }
        }

        public IProcessContext Initialize(bool throwExceptions = true)
        {
            var context = new ProcessContext(this, throwExceptions)
            {
                Status = ProcessContextStatus.Initialized
            };
            return context;
        }
    }
}
