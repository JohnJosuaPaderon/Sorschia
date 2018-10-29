using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Sorschia.Converters
{
    public sealed class MessageBoxButtonVisibilityConverter : ValueConverterBase, IValueConverter
    {
        static MessageBoxButtonVisibilityConverter()
        {
            Instance = new MessageBoxButtonVisibilityConverter();
        }

        public static MessageBoxButtonVisibilityConverter Instance { get; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is MessageBoxButton button && parameter is string param)
            {
                var visible = false;
                switch (param)
                {
                    case "OK":
                        visible = button == MessageBoxButton.OK || button == MessageBoxButton.OKCancel;
                        break;
                    case "Cancel":
                        visible = button == MessageBoxButton.OKCancel || button == MessageBoxButton.YesNoCancel;
                        break;
                    case "Yes":
                    case "No":
                        visible = button == MessageBoxButton.YesNo || button == MessageBoxButton.YesNoCancel;
                        break;
                }

                return visible ? Visibility.Visible : Visibility.Collapsed;
            }
            else
            {
                return Binding.DoNothing;
            }
        }
    }
}
