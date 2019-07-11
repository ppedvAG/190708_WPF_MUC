using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
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

namespace Media
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

        private void ButtonKlickMich_Click(object sender, RoutedEventArgs e)
        {
            Console.Beep();
            Console.Beep(500,250);
        }

        private void ButtonMediaElementStart_Click(object sender, RoutedEventArgs e)
        {
            mediaElement.Source = new Uri($"{Environment.CurrentDirectory}\\nirvana.wav");
            mediaElement.LoadedBehavior = MediaState.Manual;
            mediaElement.SpeedRatio = 5;
            mediaElement.Play();
        }

        private void ButtonSpeak_Click(object sender, RoutedEventArgs e)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Volume = 100;
            // synth.Rate = -10;
            var voices = synth.GetInstalledVoices();
            synth.SelectVoice(voices[0].VoiceInfo.Name);
            synth.Speak(textBoxSpeech.Text);
        }
    }
}
