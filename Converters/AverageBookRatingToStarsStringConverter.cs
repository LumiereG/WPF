using Potter.API;
using Potter.API.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Data;

namespace MiNIPotter.Converters
{
    public class AverageBookRatingToStarsStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is ICollection<Chapter> chapters && chapters.Any())
            {
                double averageRating = chapters.Average(c => c.Rating);
                int stars = (int)Math.Clamp(averageRating, 0, 10);
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
