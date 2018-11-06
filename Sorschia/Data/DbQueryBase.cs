namespace Sorschia
{
    internal abstract class DbQueryBase : IDbQuery
    {
        public DbQueryBase(DbQueryType type)
        {
            Type = type;
            Parameters = new DbQueryParameterCollection();
        }

        public string Command { get; set; }
        public DbQueryType Type { get; }
        public IDbQueryParameterCollection Parameters { get; }
    }
}
