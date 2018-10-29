using System.IO;
using System.Windows.Media.Imaging;

namespace Sorschia
{
    public static class BitmapImageExtension
    {
        public static byte[] ToByteArray(this BitmapImage instance)
        {
            byte[] result;
            JpegBitmapEncoder encoder = new JpegBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(instance));
            using (MemoryStream ms = new MemoryStream())
            {
                encoder.Save(ms);
                result = ms.ToArray();
            }
            return result;
        }

        
    }
}
