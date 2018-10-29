using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace Sorschia.Converters
{
    public sealed class ByteArrayBitmapImageConverter : ValueConverterBase, IValueConverter
    {
        static ByteArrayBitmapImageConverter()
        {
            Instance = new ByteArrayBitmapImageConverter();
        }

        public static ByteArrayBitmapImageConverter Instance { get; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is byte[] byteArray)
            {
                return byteArray.ToBitmapImage();
            }
            else
            {
                return null;
            }
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is BitmapImage bitmapImage)
            {
                return bitmapImage.ToByteArray();
            }
            else
            {
                return null;
            }
        }
    }
}
