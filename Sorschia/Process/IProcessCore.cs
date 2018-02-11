using System;

namespace Sorschia.Process
{
    public interface IProcessCore : IDisposable
    {
        Guid Key { get; }
    }
}
