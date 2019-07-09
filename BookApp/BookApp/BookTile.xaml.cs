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
    /// Interaction logic for BookTile.xaml
    /// </summary>
    public partial class BookTile : Border
    {
        public BookTile()
        {
            InitializeComponent();
        }

        // Anleitung:
        // 1) DependencyProperty mit propdp + TAB + TAB erstellen
        // 2) Datentyp anpassen
        // 3) Ownerclass auf die Klasse, in der man sich befindet (BookTile) anpassen
        // 4) PropertyMetaData auf einen Standardwert für den Datentyp setzen (hier string.empty)

        // propdp + TAB + TAB
        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }
        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(string), typeof(BookTile), new PropertyMetadata(string.Empty));

        public string Author
        {
            get { return (string)GetValue(AuthorProperty); }
            set { SetValue(AuthorProperty, value); }
        }
        public static readonly DependencyProperty AuthorProperty =
            DependencyProperty.Register("Author", typeof(string), typeof(BookTile), new PropertyMetadata(string.Empty));

        public string ImageURL
        {
            get { return (string)GetValue(ImageURLProperty); }
            set { SetValue(ImageURLProperty, value); }
        }
        public static readonly DependencyProperty ImageURLProperty =
            DependencyProperty.Register("ImageURL", typeof(string), typeof(BookTile), new PropertyMetadata(string.Empty));
    }
}
