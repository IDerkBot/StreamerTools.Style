using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace StreamerTools.Style.Converters
{
    public class TextClearVisibilityConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            bool canClear = values.Length > 0 && values[0] is true;
            string text = values.Length > 1 ? values[1] as string : null;

            return canClear && !string.IsNullOrEmpty(text) ? Visibility.Visible : Visibility.Collapsed;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture) => throw new NotImplementedException();
    }
}
