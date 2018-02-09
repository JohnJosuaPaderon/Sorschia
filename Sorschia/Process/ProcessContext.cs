using System;
using System.Collections.Generic;

namespace Sorschia.Process
{
    internal sealed class ProcessContext : IProcessContext
    {
        public static void TryAddFinalizer(IProcessContext context, Action<IProcessContext> finalizer)
        {
            if (context is ProcessContext concrete)
            {
                concrete.Finalizers.Add(finalizer);
            }
            else
            {
                throw new ProcessContextException("Failed to add finalizer to process context.");
            }
        }

        public ProcessContext(IProcessContextManager manager)
        {
            _Manager = manager;
            Key = Guid.NewGuid();
            Status = ProcessContextStatus.NotSet;
            Finalizers = new List<Action<IProcessContext>>();
        }

        private readonly IProcessContextManager _Manager;

        public Guid Key { get; }
        public ProcessContextStatus Status { get; set; }
        public List<Action<IProcessContext>> Finalizers { get; }

        public void Dispose()
        {
            _Manager.Finalize(this);
        }
    }
}
