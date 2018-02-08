using System;

namespace Sorschia.Process
{
    /// <summary>
    /// Represents the management of <see cref="IProcessContext"/>
    /// </summary>
    public interface IProcessContextFactory
    {
        /// <summary>
        /// Initializes a new instance of <see cref="IProcessContext"/>
        /// </summary>
        IProcessContext Initialize();

        /// <summary>
        /// Mark the context as finished
        /// </summary>
        void Finish(IProcessContext context);

        /// <summary>
        /// Catches an <see cref="Exception"/> and mark the context as faulted
        /// </summary>
        void CatchException(IProcessContext context, Exception exception);
    }
}
