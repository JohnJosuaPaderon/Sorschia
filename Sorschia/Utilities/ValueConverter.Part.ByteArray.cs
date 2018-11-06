namespace Sorschia
{
    partial class ValueConverter
    {
        /// <summary>
        /// Converts <see cref="object"/> to an array of <see cref="byte"/>
        /// </summary>
        public static byte[] ToByteArray(object value)
        {
            if (value is byte[] bytes)
            {
                return bytes;
            }
            else
            {
                return default(byte[]);
            }
        }
    }
}
