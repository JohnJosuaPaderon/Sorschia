using MaterialDesignThemes.Wpf;
using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Sorschia.Converters
{
    public sealed class MessageBoxImagePackIconKindConverter : ValueConverterBase, IValueConverter
    {
        static MessageBoxImagePackIconKindConverter()
        {
            Instance = new MessageBoxImagePackIconKindConverter();
        }

        public static MessageBoxImagePackIconKindConverter Instance { get; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is MessageBoxImage image)
            {
                switch (image)
                {
                    case MessageBoxImage.None: return Binding.DoNothing;
                    case MessageBoxImage.Question: return PackIconKind.QuestionMarkCircle;
                    case MessageBoxImage.Stop: return PackIconKind.CloseCircle;
                    case MessageBoxImage.Warning: return PackIconKind.WarningCircle;
                    case MessageBoxImage.Information: return PackIconKind.Information;
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
