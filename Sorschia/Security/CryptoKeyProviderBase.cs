using System;
using System.IO;
using System.Security;

namespace Sorschia
{
    public abstract class CryptoKeyProviderBase
    {
        public CryptoKeyProviderBase(bool encrypted, string cryptoKeyBaseDirectory, string cryptoKeyFile)
        {
            Validator.NullOrWhiteSpace(cryptoKeyFile, "Invalid crypto key file.");
            Validator.NullOrWhiteSpace(cryptoKeyBaseDirectory, "Crypto key base directory is invalid.");
            Encrypted = encrypted;
            BaseDirectoryPath = cryptoKeyBaseDirectory;
            CryptoKeyPath = Path.Combine(BaseDirectoryPath, cryptoKeyFile);
        }

        protected bool Encrypted { get; }
        protected string BaseDirectoryPath { get; }
        protected string CryptoKeyPath { get; }
        private SecureString SecureCryptoKey { get; set; }

        private void ResolveBaseDirectory()
        {
            if (!Directory.Exists(BaseDirectoryPath))
            {
                Directory.CreateDirectory(BaseDirectoryPath);
            }
        }

        private string GetInternalCryptoKey()
        {
            return $"{Environment.MachineName}\\{Environment.UserName}";
        }

        private string TryEncrypt(string plainText)
        {
            return Encrypted ? Crypto.Encrypt(plainText, GetInternalCryptoKey()) : plainText;
        }

        private string TryDecrypt(string cipherText)
        {
            return Encrypted ? Crypto.Decrypt(cipherText, GetInternalCryptoKey()) : cipherText;
        }

        public void Install(string cryptoKey)
        {
            Validator.NullOrWhiteSpace(cryptoKey, "Invalid crypto key.");
            var hash = Hashing.ComputeSHA512(cryptoKey);
            ResolveBaseDirectory();
            File.WriteAllText(CryptoKeyPath, TryEncrypt(hash));
            SecureCryptoKey = SecureStringConverter.Convert(hash);
        }

        public string Request()
        {
            if (SecureCryptoKey != null)
            {
                return SecureStringConverter.Convert(SecureCryptoKey);
            }
            else if (File.Exists(CryptoKeyPath))
            {
                var content = File.ReadAllText(CryptoKeyPath);

                if (string.IsNullOrWhiteSpace(content))
                {
                    throw new InvalidDataException("Crypto key is not installed.");
                }
                else
                {
                    SecureCryptoKey = SecureStringConverter.Convert(TryDecrypt(content));
                    return SecureStringConverter.Convert(SecureCryptoKey);
                }
            }
            else
            {
                throw new InvalidDataException("Crypto key is not installed.");
            }
        }

        public bool Verify()
        {
            if (File.Exists(CryptoKeyPath))
            {
                var content = File.ReadAllText(CryptoKeyPath);

                if (string.IsNullOrWhiteSpace(content))
                {
                    return false;
                }
                else
                {
                    SecureCryptoKey = SecureStringConverter.Convert(TryDecrypt(content));
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
