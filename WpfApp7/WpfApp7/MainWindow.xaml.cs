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

namespace WpfApp7
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> list;
        public MainWindow()
        {
            InitializeComponent();
            list = new List<string>()
            {
                "Товар 1",
                "Товар 2",
                "Товар 3",
                "Товар 4",
                "Товар 5",
                "Товар 6",
                "Товар 7",
                "Товар 8",
            };
            Singleton.ItemList = new List<string>();
        }



        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lv1.ItemsSource = list;
        }

        private void lv1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lv1.SelectedItem != null)
            {
                Singleton.ItemList.Add(lv1.SelectedItem.ToString());
                lv1.SelectedItem= null;
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
            Close();
        }
    }
}
