using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Message_Demo
{
    /// <summary>
    /// Interaction logic for ZweitesFenster.xaml
    /// </summary>
    public partial class ZweitesFenster : Window
    {
        public ZweitesFenster(Label labelWert)
        {
            InitializeComponent();
            this.labelWert = labelWert;
        }
        private readonly Label labelWert;

        private void SliderWert_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            labelWert.Content = sliderWert.Value;
        }
    }
}
