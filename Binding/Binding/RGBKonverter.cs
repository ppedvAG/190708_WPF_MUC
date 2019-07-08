using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace Binding
{
    class RGBKonverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values == null)
                return null;

            byte r = System.Convert.ToByte(values[0]);
            byte g = System.Convert.ToByte(values[1]);
            byte b = System.Convert.ToByte(values[2]);

            return new SolidColorBrush(Color.FromRgb(r,g,b));
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
