using System.Collections.Generic;

namespace Sorschia
{
    public interface IConfigurationProvider
    {
        object this[string key] { get; set; }
        void Save();
        Dictionary<string, object> GetAll();
    }
}
