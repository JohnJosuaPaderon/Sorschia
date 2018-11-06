namespace Sorschia
{
    /// <summary>
    /// Status for <see cref="IProcessContext"/>
    /// </summary>
    public enum ProcessContextStatus
    {
        /// <summary>
        /// The process status is not set
        /// </summary>
        NotSet = 0,

        /// <summary>
        /// The process is first initialized
        /// </summary>
        Initialized = 1,

        /// <summary>
        /// The process is faulted
        /// </summary>
        Faulted = 2,

        /// <summary>
        /// The process finished successfully
        /// </summary>
        Finished = 4
    }
}
