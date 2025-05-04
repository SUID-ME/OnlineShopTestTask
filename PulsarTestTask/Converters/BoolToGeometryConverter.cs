using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Globalization;

namespace PulsarTestTask.Converters
{
    public class BoolToGeometryConverter : IValueConverter
    {
        public static readonly BoolToGeometryConverter Instance = new();

        const string checkMark = "M4,12 L9,17 L20,6";
        const string crossMark = "M 5,5 L 19,19 M 5,19 L 19,5";

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool isAvailable)
            {
                return Geometry.Parse(isAvailable ? checkMark : crossMark);
            }
            return Geometry.Parse("");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
