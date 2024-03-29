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
    /// Логика взаимодействия для Window7.xaml
    /// </summary>
    public partial class Window7 : Window
    {
        public Window7()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Sqwe();
        }
        public void Sqwe()
        {
            try
            {
                for (int i = 1; i <= 10; i++)
                {
                    for (int j = 1; j <= 10; j++)
                    {
                        tb.Text += (i * j).ToString() + '\t';
                    }
                    tb.Text += '\n';
                }
            }
            catch (Exception ex)
            {
            
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
