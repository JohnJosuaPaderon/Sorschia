﻿using System;
using System.Collections.Generic;

namespace Sorschia
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
                throw new Exception("Failed to add finalizer to process context.");
            }
        }

        public ProcessContext(IProcessContextManager manager, bool throwExceptions)
        {
            Manager = manager;
            Key = Guid.NewGuid();
            Status = ProcessContextStatus.NotSet;
            Finalizers = new List<Action<IProcessContext>>();
            ThrowExceptions = throwExceptions;
        }

        private IProcessContextManager Manager { get; }

        public Guid Key { get; }
        public ProcessContextStatus Status { get; set; }
        public List<Action<IProcessContext>> Finalizers { get; }
        public bool ThrowExceptions { get; set; }

        public void Dispose()
        {
            Manager.Finalize(this);
        }
    }
}
