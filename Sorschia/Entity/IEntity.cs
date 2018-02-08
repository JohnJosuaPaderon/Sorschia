namespace Sorschia.Entity
{
    /// <summary>
    /// A representational data that has an identifier
    /// </summary>
    public interface IEntity<TId>
    {
        /// <summary>
        /// Gets or sets the identifier
        /// </summary>
        TId Id { get; set; }
    }
}
