using System;
using System.Globalization;
using System.Windows.Data;

namespace Sorschia.Converters
{
    public sealed class MonthConverter : ValueConverterBase, IValueConverter
    {
        private const string STRING_JANUARY = "January";
        private const string STRING_FEBRUARY = "February";
        private const string STRING_MARCH = "March";
        private const string STRING_APRIL = "April";
        private const string STRING_MAY = "May";
        private const string STRING_JUNE = "June";
        private const string STRING_JULY = "July";
        private const string STRING_AUGUST = "August";
        private const string STRING_SEPTEMBER = "September";
        private const string STRING_OCTOBER = "October";
        private const string STRING_NOVEMBER = "November";
        private const string STRING_DECEMBER = "December";

        private const int INT_JANUARY = 1;
        private const int INT_FEBRUARY = 2;
        private const int INT_MARCH = 3;
        private const int INT_APRIL = 4;
        private const int INT_MAY = 5;
        private const int INT_JUNE = 6;
        private const int INT_JULY = 7;
        private const int INT_AUGUST = 8;
        private const int INT_SEPTEMBER = 9;
        private const int INT_OCTOBER = 10;
        private const int INT_NOVEMBER = 11;
        private const int INT_DECEMBER = 12;

        static MonthConverter()
        {
            Instance = new MonthConverter();
        }

        public static MonthConverter Instance { get; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is int intValue)
            {
                switch (intValue)
                {
                    case INT_JANUARY: return STRING_JANUARY;
                    case INT_FEBRUARY: return STRING_FEBRUARY;
                    case INT_MARCH: return STRING_MARCH;
                    case INT_APRIL: return STRING_APRIL;
                    case INT_MAY: return STRING_MAY;
                    case INT_JUNE: return STRING_JUNE;
                    case INT_JULY: return STRING_JULY;
                    case INT_AUGUST: return STRING_AUGUST;
                    case INT_SEPTEMBER: return STRING_SEPTEMBER;
                    case INT_OCTOBER: return STRING_OCTOBER;
                    case INT_NOVEMBER: return STRING_NOVEMBER;
                    case INT_DECEMBER: return STRING_DECEMBER;
                    default: return Binding.DoNothing;
                }
            }
            else
            {
                return Binding.DoNothing;
            }
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string stringValue)
            {
                switch (stringValue)
                {
                    case STRING_JANUARY: return INT_JANUARY;
                    case STRING_FEBRUARY: return INT_FEBRUARY;
                    case STRING_MARCH: return INT_MARCH;
                    case STRING_APRIL: return INT_APRIL;
                    case STRING_MAY: return INT_MAY;
                    case STRING_JUNE: return INT_JUNE;
                    case STRING_JULY: return INT_JULY;
                    case STRING_AUGUST: return INT_AUGUST;
                    case STRING_SEPTEMBER: return INT_SEPTEMBER;
                    case STRING_OCTOBER: return INT_OCTOBER;
                    case STRING_NOVEMBER: return INT_NOVEMBER;
                    case STRING_DECEMBER: return INT_DECEMBER;
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
