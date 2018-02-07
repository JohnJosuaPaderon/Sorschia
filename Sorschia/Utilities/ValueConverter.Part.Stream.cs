using System.IO;

namespace Sorschia.Utilities
{
    partial class ValueConverter
    {
        /// <summary>
        /// Converts <see cref="object"/> to <see cref="Stream"/>
        /// </summary>
        public static Stream ToStream(object value)
        {
            return value == null ? null : ConvertBase(value, val => new MemoryStream(ToByteArray(val)));
        }
    }
}
