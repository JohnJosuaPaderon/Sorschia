using System;
using System.Globalization;
using System.Windows.Data;

namespace Sorschia
{
    public abstract class ValueConverterBase
    {
        public virtual object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Binding.DoNothing;
        }
    }
}
