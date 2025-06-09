using System;
using System.Globalization;
using System.Windows.Data;

namespace Car_Rental
{
    public class BoolToStatusConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool isAvailable)
            {
                return isAvailable ? "Dost�pny" : "Niedost�pny";
            }
            return "Nieznany";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException("Konwersja wsteczna nie jest obs�ugiwana.");
        }
    }
}