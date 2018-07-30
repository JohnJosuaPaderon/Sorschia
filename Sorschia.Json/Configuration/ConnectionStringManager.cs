using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Sorschia.Security;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Sorschia.Configuration
{
    internal sealed class ConnectionStringManager : ConnectionStringManagerBase, IConnectionStringManager
    {
        private const string FIELD_KEY = "key";
        private const string FIELD_VALUE = "value";

        public ConnectionStringManager(IConnectionStringSourceFileProvider sourceFileProvider)
        {
            Validator.Null(sourceFileProvider, "Invalid connection string source file.");
            SourceFileProvider = sourceFileProvider;
        }

        private IConnectionStringSourceFileProvider SourceFileProvider { get; }

        public override void Save()
        {
            if (Source.Any())
            {
                var json = new JArray();

                foreach (var item in Source)
                {
                    json.Add(new JObject
                    {
                        { FIELD_KEY, item.Key },
                        { FIELD_VALUE, SecureStringConverter.Convert(item.Value) }
                    });
                }

                using (var writer = File.CreateText(SourceFileProvider.Path))
                {
                    using (var textWriter = new JsonTextWriter(writer))
                    {
                        textWriter.Formatting = Formatting.Indented;
                        textWriter.Indentation = 4;
                        json.WriteTo(textWriter);
                    }
                }
            }
        }

        protected override IEnumerable<(string key, string value)> Load()
        {
            if (File.Exists(SourceFileProvider.Path))
            {
                using (var reader = File.OpenText(SourceFileProvider.Path))
                {
                    using (var textReader = new JsonTextReader(reader))
                    {
                        var json = (JArray)JToken.ReadFrom(textReader);
                        var result = new List<(string key, string value)>();

                        foreach (JObject item in json)
                        {
                            result.Add((item[FIELD_KEY].ToString(), item[FIELD_VALUE].ToString()));
                        }

                        return result;
                    }
                }
            }
            else
            {
                return null;
            }
        }
    }
}
