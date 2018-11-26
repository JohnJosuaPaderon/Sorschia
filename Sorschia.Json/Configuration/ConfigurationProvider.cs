using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Sorschia
{
    internal sealed class ConfigurationProvider : ConfigurationProviderBase, IConfigurationProvider
    {
        private const string FIELD_KEY = "key";
        private const string FIELD_VALUE = "value";

        public ConfigurationProvider(IConfigurationSourceFileProvider sourceFileProvider)
        {
            Validator.Null(sourceFileProvider, "Invalid configuration source file.");
            SourceFileProvider = sourceFileProvider;
        }

        private IConfigurationSourceFileProvider SourceFileProvider { get; }

        public override void Save()
        {
            if (Source.Any())
            {
                var json = new JObject();

                foreach (var item in Source)
                {
                    json.Add(item.Key, JToken.FromObject(item.Value));
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

        protected override IEnumerable<(string key, object value)> Load()
        {
            if (File.Exists(SourceFileProvider.Path))
            {
                using (var reader = File.OpenText(SourceFileProvider.Path))
                {
                    using (var textReader = new JsonTextReader(reader))
                    {
                        var json = (JObject)JToken.ReadFrom(textReader);
                        var result = new List<(string key, object value)>();

                        foreach (var item in json)
                        {
                            result.Add((item.Key, item.Value.Type == JTokenType.Null ? null : item.Value));
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
