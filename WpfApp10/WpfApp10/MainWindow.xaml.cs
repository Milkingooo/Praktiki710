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

namespace WpfApp10
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1= new Window1();
            window1.Show();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window2 window2 = new Window2();
            window2.Show();
            Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Window3 window3window3 = new Window3();
            window3window3.Show();
            Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Window4 window4 = new Window4();
            window4.Show();
            Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Window5 window5 = new Window5();
            window5.Show();
            Close();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Window6 window6window6 = new Window6();
            window6window6.Show();
            Close();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Window7 window7 = new Window7();
            window7.Show();
            Close();
        }
    }
}
