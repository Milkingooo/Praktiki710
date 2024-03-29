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
    /// Логика взаимодействия для Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        public Window5()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Ex5();
        }
        public void Ex5()
        {
            try
            {
                int[] numbers = new int[8];
                string[] strings = new string[8];
                string st = tb2.Text;
                strings = st.Split(' ');
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = Convert.ToInt32(strings[i]);
                }
                int signChanges = 0;

                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    if (Math.Sign(numbers[i]) != Math.Sign(numbers[i + 1]))
                    {
                        signChanges++;
                    }
                }
                tb.Text = $"Изменяется: {signChanges} раз";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();    
        }
    }
}
