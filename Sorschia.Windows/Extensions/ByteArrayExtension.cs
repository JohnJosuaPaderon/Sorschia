using System.IO;
using System.Windows.Media.Imaging;

namespace Sorschia
{
    public static class ByteArrayExtension
    {
        public static BitmapImage ToBitmapImage(this byte[] instance)
        {
            using (var stream = new MemoryStream(instance))
            {
                var result = new BitmapImage();
                result.BeginInit();
                result.CacheOption = BitmapCacheOption.OnLoad;
                result.StreamSource = stream;
                result.EndInit();
                return result;
            }
        }
    }
}
