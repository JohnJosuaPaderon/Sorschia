using System.IO;
using System.IO.Compression;

namespace Sorschia
{
    /// <summary>
    /// Exposes functions that compress and decompress <see cref="byte"/>[]
    /// </summary>
    public static class Compressor
    {
        /// <summary>
        /// Compresses the <see cref="byte"/>[]
        /// </summary>
        public static byte[] Compress(byte[] uncompressed)
        {
            var output = new MemoryStream();

            using (var deflateStream = new DeflateStream(output, CompressionLevel.Optimal))
            {
                deflateStream.Write(uncompressed, 0, uncompressed.Length);
            }

            return output.ToArray();
        }

        /// <summary>
        /// Decompresses the <see cref="byte"/>[]
        /// </summary>
        public static byte[] Decompress(byte[] compressed)
        {
            var input = new MemoryStream(compressed);
            var output = new MemoryStream();

            using (var deflateStream = new DeflateStream(input, CompressionMode.Decompress))
            {
                deflateStream.CopyTo(output);
            }

            return output.ToArray();
        }
    }
}
