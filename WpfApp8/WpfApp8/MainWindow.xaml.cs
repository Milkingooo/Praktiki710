using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices.ComTypes;
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
using System.Xml.Linq;

namespace WpfApp8
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int points = 0;
        public int num = 1;

        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            num++;
            if (num <= 7) 
            {
            
            }
            UpdateQwe();
            Ganswer();
            Gqwe();
        }
        public void UpdateQwe()
        {
            AnswNum.Content = "Вопрос " + num;
        }
        public void Ganswer()
        {
            switch (AnswNum.Content)
            {
                case "Вопрос 1":
                    AnswImg.Source = new BitmapImage(new Uri("/Assets/Image/acer.png", UriKind.Relative));
                    Qwest.Content = "Как правильно называется?";
                    Rb1.Content = "Эйсер";
                    Rb2.Content = "Высер";
                    Rb3.Content = "Асер";
                    break;
                case "Вопрос 2":
                    AnswImg.Source = new BitmapImage(new Uri("/Assets/Image/putin.png", UriKind.Relative));
                    Qwest.Content = "Какое это обновление?";
                    Rb1.Content = "1.14";
                    Rb2.Content = "1.16";
                    Rb3.Content = "1.18";
                    break;
                    
            }
        }
        public void Gqwe()
        {
            switch (AnswNum.Content)
            {
                case "Вопрос 1":
                    if (Rb2.IsChecked == true)
                        points++;
                    Rb2.IsChecked = false;
                    break;
                case "Вопрос 2":
                    if (Rb2.IsChecked == true)
                        points++;
                    Rb2.IsChecked = false;
                    break;
            }
        }


    }
}
