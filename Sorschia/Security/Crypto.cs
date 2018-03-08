using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Sorschia.Security
{
    public static class Crypto
    {
        private const int KEY_SIZE = 256;
        private const int DERIVATION_ITERATIONS = 1000;

        private static RijndaelManaged InitializeAlgorithm()
        {
            return new RijndaelManaged()
            {
                BlockSize = 256,
                Mode = CipherMode.CBC,
                Padding = PaddingMode.PKCS7
            };
        }

        private static byte[] GetKeyBytes(Rfc2898DeriveBytes cryptoKeyBytes)
        {
            return cryptoKeyBytes.GetBytes(KEY_SIZE / 8);
        }

        public static string Encrypt(string value, string cryptoKey)
        {
            return Encrypt(value, cryptoKey, RandomBytes.Generate(), RandomBytes.Generate());
        }

        public static string Encrypt(string value, string cryptoKey, byte[] salt, byte[] iv)
        {
            Validator.NullOrWhiteSpace(value, "Cannot encrypt null or white space string.");
            Validator.NullOrWhiteSpace(cryptoKey, "Crypto key is required.");
            Validator.Null(salt, "Salt is required.");
            Validator.Null(iv, "IV is required.");

            var valueBytes = Encoding.UTF8.GetBytes(value);

            using (var cryptoKeyBytes = new Rfc2898DeriveBytes(cryptoKey, salt, DERIVATION_ITERATIONS))
            {
                using (var algorithm = InitializeAlgorithm())
                {
                    using (var encryptor = algorithm.CreateEncryptor(GetKeyBytes(cryptoKeyBytes), iv))
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                            {
                                cryptoStream.Write(valueBytes, 0, valueBytes.Length);
                                cryptoStream.FlushFinalBlock();

                                var resultBytes = salt;
                                resultBytes = resultBytes.Concat(iv).ToArray();
                                resultBytes = resultBytes.Concat(memoryStream.ToArray()).ToArray();

                                return Convert.ToBase64String(resultBytes);
                            }
                        }
                    }
                }
            }
        }

        public static string Decrypt(string value, string cryptoKey)
        {
            Validator.NullOrWhiteSpace(value, "Cannot decrypt null or white space string.");
            Validator.NullOrWhiteSpace(cryptoKey, "Crypto key is required.");

            var valueBytes = Convert.FromBase64String(value);
            var saltSize = KEY_SIZE / 8;
            var ivSize = KEY_SIZE / 8;
            var valueSize = valueBytes.Length - (saltSize + ivSize);
            var salt = valueBytes.Take(saltSize).ToArray();
            var iv = valueBytes.Skip(saltSize).Take(ivSize).ToArray();
            valueBytes = valueBytes.Skip(saltSize + ivSize).Take(valueSize).ToArray();

            using (var cryptoKeyBytes = new Rfc2898DeriveBytes(cryptoKey, salt, DERIVATION_ITERATIONS))
            {
                using (var algorithm = InitializeAlgorithm())
                {
                    using (var decryptor = algorithm.CreateDecryptor(GetKeyBytes(cryptoKeyBytes), iv))
                    {
                        using (var memoryStream = new MemoryStream(valueBytes))
                        {
                            using (var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                            {
                                var resultBytes = new byte[valueBytes.Length];
                                var resultByteCount = cryptoStream.Read(resultBytes, 0, resultBytes.Length);

                                return Encoding.UTF8.GetString(resultBytes, 0, resultByteCount);
                            }
                        }
                    }
                }
            }
        }
    }
}
