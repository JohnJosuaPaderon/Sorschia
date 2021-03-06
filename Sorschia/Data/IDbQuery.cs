﻿namespace Sorschia
{
    public interface IDbQuery
    {
        string Command { get; set; }
        DbQueryType Type { get; }
        IDbQueryParameterCollection Parameters { get; }
    }
}
