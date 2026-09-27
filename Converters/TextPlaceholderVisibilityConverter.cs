using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace StreamerTools.Style.Converters
{
    public class TextPlaceholderVisibilityConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            string text = values.Length > 0 ? values[0] as string : null;
            string placeholder = values.Length > 1 ? values[1] as string : null;

            return string.IsNullOrEmpty(text) && !string.IsNullOrEmpty(placeholder)
                ? Visibility.Visible
                : Visibility.Collapsed;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture) => throw new NotImplementedException();
    }
}
