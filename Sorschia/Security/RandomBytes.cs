﻿using System.Security.Cryptography;

namespace Sorschia
{
    public static class RandomBytes
    {
        public static byte[] Generate(int size = 32)
        {
            var randomBytes = new byte[size];

            using (var provider = new RNGCryptoServiceProvider())
            {
                provider.GetBytes(randomBytes);
            }

            return randomBytes;
        }
    }
}
