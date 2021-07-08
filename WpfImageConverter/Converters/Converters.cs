using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace WpfImageConverter.Converters
{
    // Convert string to a color
    public class ColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value == null) return new SolidColorBrush(Color.FromRgb(0, 0, 0));

            if (value.ToString().ToUpper() == "RED")
            {
                return new SolidColorBrush(Color.FromRgb(255, 0, 0));
            }
            else if (value.ToString().ToUpper() == "GREEN")
            {
                return new SolidColorBrush(Color.FromRgb(0, 255, 0));
            }
            else if (value.ToString().ToUpper() == "BLUE")
            {
                return new SolidColorBrush(Color.FromRgb(0, 0, 255));
            }
            else
            {
                return new SolidColorBrush(Color.FromRgb(0, 0, 0));
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return null;
        }
    }

    // Convert string to a color
    public class ImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if ((value == null) || ((value as string) == string.Empty)) value = "poison";

            var name = $"pack://application:,,/Images/{value as string}.png";

            // name = $"Images/{value as string}.png";


            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(name, UriKind.RelativeOrAbsolute);
            image.EndInit();

            return image;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return null;
        }


    }
}
