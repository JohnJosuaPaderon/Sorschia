namespace Sorschia
{
    /// <summary>
    /// A representational data that has an identifier
    /// </summary>
    public interface IEntity<TId>
    {
        /// <summary>
        /// Gets the identifier
        /// </summary>
        TId Id { get; }
    }
}
