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
    /// Логика взаимодействия для Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int[] numbers = new int[6];
            string[] strings = new string[6];
            string st = tb2.Text;
            strings = st.Split(' ');
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(strings[i]);   
            }
            FindMinMax(numbers);        
        }

        private void FindMinMax(int[] numbers)
        {
            int max = int.MinValue;
            int min = int.MaxValue;
            foreach (int num in numbers)
            {
                if (num < min)
                {
                    min = num;
                }
               if (num > max)
                {
                    max = num;
                }
            }
            tb.Text = "Min number: " + min + "\n" + "Max number: " + max;
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }
}
