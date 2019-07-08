using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Binding
{
    class FaktorKonverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                int wert = System.Convert.ToInt32(value);
                int faktor = System.Convert.ToInt32(parameter);

                return wert * faktor;
            }
            catch (Exception)
            {
                return 0;
            }
 
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
