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
using System.Windows.Threading;

namespace WpfApp9
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();
            timer.Interval = TimeSpan.FromSeconds(0.1);
            timer.Tick += timer_tick;
        }
        private void timer_tick(object sender, EventArgs e)
        {
            time.Text = media1.Position.ToString(@"mm\:ss");
            slider2.Value = media1.Position.TotalSeconds;
        }
        private void playButton_Click(object sender, RoutedEventArgs e)
        {
            media1.Play();
            timer.Start();
        }

        private void pauseButton_Click(object sender, RoutedEventArgs e)
        {
            media1.Pause();
            timer.Stop();
        }

        private void stopButton_Click(object sender, RoutedEventArgs e)
        {
            media1.Stop();
            timer.Stop();
        }

        private void media1_MediaOpened(object sender, RoutedEventArgs e)
        {
            slider2.Maximum = media1.NaturalDuration.TimeSpan.TotalSeconds;
        }
        private void slider2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            slider2.Maximum = media1.NaturalDuration.TimeSpan.TotalSeconds;
            media1.Pause();
            media1.Position = TimeSpan.FromSeconds(slider2.Value);
            media1.Play();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           media1.Source = new Uri("C:/Users/Пользователь/Documents/ИС-22/Bad boys/WpfApp9/WpfApp9/Assets/Videos/FlexAir81.mp4");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            media1.Source = new Uri(openFileDialog.FileName);
        }
    }
       
    }
