using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace MiNIPotter.Converters
{
    public class RatingToStarColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is double rating)
            {
                double clampedRating = Math.Clamp(rating, 0, 10);
                byte red = (byte)((1 - (clampedRating / 10.0)) * 192);
                byte green = (byte)((clampedRating / 10.0) * 192);
                byte blue = 0;
                return new SolidColorBrush(Color.FromRgb(red, green, blue));
            }
            return Brushes.Gray; // Domyślny kolor, jeśli coś pójdzie nie tak
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}