using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Sorschia.Converters
{
    public sealed class BooleanVisibilityConverter : ValueConverterBase, IValueConverter
    {
        static BooleanVisibilityConverter()
        {
            Instance = new BooleanVisibilityConverter();
        }

        public static BooleanVisibilityConverter Instance { get; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool boolValue)
            {
                return boolValue ? Visibility.Visible : Visibility.Collapsed;
            }
            else
            {
                return Binding.DoNothing;
            }
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Visibility visibility)
            {
                switch (visibility)
                {
                    case Visibility.Visible: return true;
                    case Visibility.Hidden: return false;
                    case Visibility.Collapsed: return false;
                    default: return Binding.DoNothing;
                }
            }
            else
            {
                return Binding.DoNothing;
            }
        }
    }
}
