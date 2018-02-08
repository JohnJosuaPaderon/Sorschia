using System;
using System.Collections.Generic;

namespace Sorschia.Process
{
    /// <summary>
    /// Base-class for implementing <see cref="IProcessContextFactory"/>
    /// </summary>
    public abstract class ProcessContextFactoryBase
    {
        /// <summary>
        /// Initializes <see cref="ProcessContextFactoryBase"/>
        /// </summary>
        public ProcessContextFactoryBase()
        {
            _ContextExceptions = new Dictionary<IProcessContext, List<Exception>>();
        }

        private readonly Dictionary<IProcessContext, List<Exception>> _ContextExceptions;

        /// <summary>
        /// Initializes a new instance of <see cref="IProcessContext"/>; This method is required by <see cref="Initialize"/>
        /// </summary>
        /// <returns></returns>
        protected abstract IProcessContext Construct();

        /// <summary>
        /// Initializes a new instance of <see cref="IProcessContext"/>
        /// </summary>
        public IProcessContext Initialize()
        {
            var result = Construct();

            if (result is ProcessContextBase context)
            {
                context.Status = ProcessContextStatus.Initialized;
                return context;
            }
            else
            {
                return default(IProcessContext);
            }
        }

        /// <summary>
        /// Mark the context as finished
        /// </summary>
        public virtual void Finish(IProcessContext context)
        {
            if (context is ProcessContextBase contextBase)
            {
                contextBase.Status = ProcessContextStatus.Finished;
            }
        }

        /// <summary>
        /// Catches an <see cref="Exception"/> and mark the context as faulted
        /// </summary>
        public void CatchException(IProcessContext context, Exception exception)
        {
            if (!_ContextExceptions.ContainsKey(context))
            {
                _ContextExceptions.Add(context, new List<Exception>());
            }

            _ContextExceptions[context].Add(exception);
        }
    }
}
