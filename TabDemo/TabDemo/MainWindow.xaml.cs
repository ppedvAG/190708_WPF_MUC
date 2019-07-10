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

namespace TabDemo
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Beim Projektstart
            //tabControlRoot.Items.Add(new UserControlTab1());
            //tabControlRoot.Items.Add(new UserControlTab1());
            //tabControlRoot.Items.Add(new UserControlTab1());
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            // Zur Laufzeit
            tabControlRoot.Items.Add(new UserControlTab1());
        }
    }
}
