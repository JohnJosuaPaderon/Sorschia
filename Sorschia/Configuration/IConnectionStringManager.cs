﻿using System.Collections.Generic;
using System.Security;

namespace Sorschia
{
    public interface IConnectionStringManager : IEnumerable<KeyValuePair<string, SecureString>>
    {
        SecureString this[string key] { get; set; }
        void Save();
        void Remove(string key);
    }
}
