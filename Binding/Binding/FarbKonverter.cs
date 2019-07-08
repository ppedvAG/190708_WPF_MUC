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
    class FarbKonverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string colorName = (string)value;

            // Varinate "primitiv"
            //if (colorName == "Rot")
            //    return Brushes.Red;
            //else
            //    return Brushes.Black;

            // Pro-Variante:
            // Übersetzer:
            if (colorName == "Rot")
                return Brushes.Red;
            else if (colorName == "Gelb")
                return Brushes.Yellow;
            else
                foreach (var item in typeof(Brushes).GetProperties())
                {
                    if (item.Name == colorName)
                        return item.GetValue(typeof(Brushes));
                }

            return Brushes.Black; // nichts finden
        }

        // TwoWay
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
