using System;
using System.Globalization;
using System.Windows.Data;

namespace MiNIPotter.Converters
{
    public class ChapterRatingToStarsStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is double rating)
            {
                int stars = (int)Math.Clamp(rating, 0, 10);
                return new string('★', stars); // Pełne gwiazdki
            }
            return string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}