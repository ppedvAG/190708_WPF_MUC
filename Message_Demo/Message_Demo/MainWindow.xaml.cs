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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Message_Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LabelAktualisieren(object data)
        {
            labelWert.Content = data;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            // Variante 3):
            ZweitesFenster f = new ZweitesFenster();
            f.Show();
        }

        private void MenuItemSubscribe_Click(object sender, RoutedEventArgs e)
        {
            MessagingService.Subscribe(MessagingService.Messages.SliderValueChanged, LabelAktualisieren);

        }

        private void MenuItemUnsubscribe_Click(object sender, RoutedEventArgs e)
        {
            MessagingService.Unsubscribe(MessagingService.Messages.SliderValueChanged, LabelAktualisieren);
        }
    }
}
