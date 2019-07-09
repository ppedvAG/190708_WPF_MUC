using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Validation
{
    class AgeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var t = value.GetType();
            double wert = System.Convert.ToDouble(value.ToString(),NumberFormatInfo.InvariantInfo);
            //if (wert > 90)
            //    throw new DivideByZeroException();

            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
