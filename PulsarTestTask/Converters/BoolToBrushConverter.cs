using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Globalization;

namespace PulsarTestTask.Converters
{
    public class BoolToBrushConverter : IValueConverter
    {
        public static readonly BoolToBrushConverter Instance = new();

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool isAvailable)
            {
                return isAvailable
                    ? Brushes.Green
                    : Brushes.Red;
            }
            return Brushes.Transparent;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
