using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace FirstWpfApp
{
    public class BackgroundColorConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            SolidColorBrush darkBrush = Brushes.DimGray;
            SolidColorBrush lightBrush = Brushes.PeachPuff;

            if (values[1] is bool lightBackground && lightBackground )
                return lightBrush;

            return darkBrush;
        }
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
