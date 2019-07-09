using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
using WPFFolderBrowser;

namespace WiederholungTag1
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
        private string currentOpen;


        private void MenuItemHilfe_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Mir ist nicht mehr zu helfen...", "Deine Hilfe ❤");
        }

        private void MenuItemÖffnen_Click(object sender, RoutedEventArgs e)
        {
            // Nuget: WPFFolderbrowser für den FolderBrowserDialog
            // WPFFolderBrowserDialog fbd = new WPFFolderBrowserDialog();
            // fbd.ShowDialog();

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Textdokument|*.txt";

            if (dlg.ShowDialog() == true)
            {
                textBoxDatei.Text = File.ReadAllText(dlg.FileName);
                if (!listBoxHistory.Items.Contains(dlg.FileName))
                    listBoxHistory.Items.Add(dlg.FileName);
                currentOpen = dlg.FileName;
                MessageBox.Show("Die Datei wurde erfolgreich geöffnet");
                listBoxHistory.SelectedIndex = listBoxHistory.Items.IndexOf(dlg.FileName);
            }
        }

        private void MenuItemSpeichern_Click(object sender, RoutedEventArgs e)
        {
            if (currentOpen != null)
            {
                File.WriteAllText(currentOpen, textBoxDatei.Text);
                MessageBox.Show("Die Datei wurde erfolgreich gespeichert");
            }
        }

        private void MenuItemSpeichernUnter_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Textdokument|*.txt";
            if (dlg.ShowDialog() == true)
            {
                File.WriteAllText(dlg.FileName, textBoxDatei.Text);
                currentOpen = dlg.FileName;
                if (!listBoxHistory.Items.Contains(dlg.FileName))
                    listBoxHistory.Items.Add(dlg.FileName);
                MessageBox.Show("Die Datei wurde erfolgreich gespeichert");
            }
        }

        private void MenuItemBeenden_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Wollen Sie das Programm wirklich beenden ?", "Beenden", MessageBoxButton.YesNo, MessageBoxImage.Information);
            if (result == MessageBoxResult.Yes)
            {
                result = MessageBox.Show("Sind Sie sich sicher ?", "Beenden", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    result = MessageBox.Show("Wirklich 😭 ?", "Beenden", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                    if (result == MessageBoxResult.Yes)
                        Close();
                }
            }

            MessageBox.Show("OK 😊");

            // Alternativen fürs Beenden:
            // Environment.Exit(0);
            // Environment.FailFast();

            // In einem Konsolenprogramm: return; in der Main()-Methode aufrufen
        }

        private void ListBoxHistory_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (listBoxHistory.SelectedItem == null)
                return;

            textBoxDatei.Text = File.ReadAllText(listBoxHistory.SelectedItem.ToString());
            currentOpen = listBoxHistory.SelectedItem.ToString();
            MessageBox.Show("Die Datei wurde erfolgreich geöffnet");
        }
    }
}
