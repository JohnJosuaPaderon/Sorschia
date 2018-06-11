using System;

namespace Sorschia.Process
{
    /// <summary>
    /// Represents a collection of information about a process or a series of processes
    /// </summary>
    public interface IProcessContext : IDisposable
    {
        /// <summary>
        /// Unique identifier of the <see cref="IProcessContext"/>
        /// </summary>
        Guid Key { get; }

        /// <summary>
        /// Status of the process
        /// </summary>
        ProcessContextStatus Status { get; }
        bool ThrowExceptions { get; }
    }
}
