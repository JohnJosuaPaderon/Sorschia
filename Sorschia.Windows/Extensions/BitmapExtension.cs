using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Media.Imaging;

namespace Sorschia
{
    public static class BitmapExtension
    {
        public static BitmapImage ToBitmapImage(this Bitmap instance)
        {
            using (var stream = new MemoryStream())
            {
                instance.Save(stream, ImageFormat.Bmp);
                stream.Position = 0;
                BitmapImage result = new BitmapImage();
                result.BeginInit();
                result.StreamSource = stream;
                result.CacheOption = BitmapCacheOption.OnLoad;
                result.EndInit();
                result.Freeze();
                return result;
            }
        }

        public static byte[] ToByteArray(this Bitmap instance)
        {
            using (var stream = new MemoryStream())
            {
                instance.Save(stream, ImageFormat.Jpeg);
                return stream.ToArray();
            }
        }
    }
}
