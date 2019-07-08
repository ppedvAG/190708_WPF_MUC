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

namespace Ressourcen
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

        private void ButtonLogin_Click(object sender, RoutedEventArgs e)
        {
            //// Style zur Laufzeit zuweisen
            //// buttonLogin.Style = (Style)this.Resources["redButtonStyle"];
            //SolidColorBrush brush = new SolidColorBrush();//  (SolidColorBrush)this.Resources["cooleFarbe"];
            //brush.Color = Colors.Tomato;

            //this.Resources["cooleFarbe"] = brush;

            this.Resources["DefaultButtonStyle"] = this.Resources["redButtonStyle"];
        }

        private void ButtonRegister_Click(object sender, RoutedEventArgs e)
        {
            this.Resources["DefaultButtonStyle"] = this.Resources["greenButtonStyle"];
        }
    }
}
