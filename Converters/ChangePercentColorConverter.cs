using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace CryptoApp.Converters
{
    public class ChangePercentColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string ChangePercent)
            {
                return ChangePercent[0] == '+' ? new SolidColorBrush(Colors.Green) : new SolidColorBrush(Colors.Red);
            }

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
