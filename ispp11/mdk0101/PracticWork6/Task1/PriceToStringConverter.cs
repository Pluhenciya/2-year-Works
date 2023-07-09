using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Task1
{
    internal class PriceToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //if ((byte)parameter == 0) 
            return $" ";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return DependencyProperty.UnsetValue;
        }
    }
}
