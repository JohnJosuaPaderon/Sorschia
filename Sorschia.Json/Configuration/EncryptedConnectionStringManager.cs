using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Sorschia
{
    internal sealed class EncryptedConnectionStringManager : ConnectionStringManagerBase, IConnectionStringManager
    {
        private const string FIELD_KEY = "key";
        private const string FIELD_VALUE = "value";

        public EncryptedConnectionStringManager(IConnectionStringSourceFileProvider sourceFileProvider, IConnectionStringCryptoKeyProvider cryptoKeyProvider)
        {
            Validator.Null(sourceFileProvider, "Invalid connection string source file.");
            Validator.Null(cryptoKeyProvider, "Invalid connection string crypto key.");
            SourceFileProvider = sourceFileProvider;
            CryptoKeyProvider = cryptoKeyProvider;
        }

        private IConnectionStringSourceFileProvider SourceFileProvider { get; }
        private IConnectionStringCryptoKeyProvider CryptoKeyProvider { get; }

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
                        { FIELD_VALUE, Crypto.Encrypt(SecureStringConverter.Convert(item.Value), CryptoKeyProvider.Key) }
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
                            result.Add((item[FIELD_KEY].ToString(), Crypto.Decrypt(item[FIELD_VALUE].ToString(), CryptoKeyProvider.Key)));
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
