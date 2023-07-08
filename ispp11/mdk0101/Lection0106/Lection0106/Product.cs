using System;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace Lection0106
{
    internal class Product : IDataErrorInfo, INotifyPropertyChanged
    {

        public string this[string columnName]
        {
            get
            {
                string error = string.Empty;
                switch (columnName)
                {
                    case "Id":
                        if (Id < 0)
                            error = "id < 0";
                        break;
                    case "Price":
                        if (Price < 0 || Price > 10000)
                            error = "0 < price < 10000";
                        break;
                }
                return error;
            }
        }

        private double _price;

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price
        {
            get => _price;
            set
            {
                if (_price != value) //if необязателен
                {
                    _price = value;
                    OnPropertyChanged();
                    // OnPropertyChanged("Имя еще одного свойства");
                }
            }
        }
        public DateTime CreationDate { get; set; }
        public Category Category { get; set; }

        public string PriceString { get => $"Цена: {Price} руб."; }

        public string Error => "";

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
    }

    public class PriceToBackgroundConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //return (Double)value > 100 ? Brushes.Aqua : Brushes.Transparent;
            return (Double)value > 1000 ? Brushes.Red : ((double)value > 500 ? "#FF0FFF" : Brushes.Transparent);

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class PriceToDecorationConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //return (Double)value > 100 ? Brushes.Aqua : Brushes.Transparent;
            return (Double)value > 1000 ? TextDecorations.Strikethrough :
                ((double)value > 500 ? TextDecorations.Underline : null);

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
