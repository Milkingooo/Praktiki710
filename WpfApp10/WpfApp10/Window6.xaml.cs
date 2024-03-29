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
using System.Windows.Shapes;

namespace WpfApp10
{
    /// <summary>
    /// Логика взаимодействия для Window6.xaml
    /// </summary>
    public partial class Window6 : Window
    {
        public Window6()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Sum();
        }
        public void Sum()
        {
            double sum = 1;

            for (int i = 1; i <= 5; i++)
            {
                double term = i * 1.0 / Factorial(i);
                sum += term;
            }
            tb.Text = "Сумма = " + sum;
        }

        public int Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }
}
