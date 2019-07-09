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

namespace BookApp
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
            listBoxBooks.Items.Add(new Book { Title = "Buch1", Author = "Lisa", ImageURL = "https://baconmockup.com/50/50/" });
            listBoxBooks.Items.Add(new Book { Title = "Buch2", Author = "Herbert", ImageURL = "https://baconmockup.com/50/50/" });
            listBoxBooks.Items.Add(new Book { Title = "Buch3", Author = "Demo", ImageURL = "https://baconmockup.com/50/50/" });
            listBoxBooks.Items.Add(new Person { Vorname = "Tom", Nachname = "Ate", Alter= 10, Kontostand=100});
            listBoxBooks.Items.Add(new Book { Title = "Buch4", Author = "Max", ImageURL = "https://baconmockup.com/50/50/" });
            listBoxBooks.Items.Add(new Book { Title = "Buch5", Author = "Demo", ImageURL = "https://baconmockup.com/50/50/" });
            listBoxBooks.Items.Add(new Book { Title = "Buch6", Author = "Max", ImageURL = "https://baconmockup.com/50/50/" });
            listBoxBooks.Items.Add(new Person { Vorname = "Anna", Nachname = "Nass", Alter= 20, Kontostand=200});
            listBoxBooks.Items.Add(new Book { Title = "Buch7", Author = "Lisa", ImageURL = "https://baconmockup.com/50/50/" });
            listBoxBooks.Items.Add(new Book { Title = "Buch8", Author = "Demo", ImageURL = "https://baconmockup.com/50/50/" });
            listBoxBooks.Items.Add(new Book { Title = "Buch9", Author = "Max", ImageURL = "https://baconmockup.com/50/50/" });
            listBoxBooks.Items.Add(new Person { Vorname = "Peter", Nachname = "Silie", Alter= 30, Kontostand= -300});
            listBoxBooks.Items.Add(new Book { Title = "Buch10", Author = "Herbert", ImageURL = "https://baconmockup.com/50/50/" });
        }
    }
}
