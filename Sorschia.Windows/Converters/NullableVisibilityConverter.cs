using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Sorschia.Converters
{
    public sealed class NullableVisibilityConverter : ValueConverterBase, IValueConverter
    {
        static NullableVisibilityConverter()
        {
            Instance = new NullableVisibilityConverter();
        }

        public static NullableVisibilityConverter Instance { get; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value == null ? Visibility.Collapsed : Visibility.Visible;
        }
    }
}
