using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Shapes;

namespace WpfApp7
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
       
        public Window1()
        {
            InitializeComponent();
           
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            GetList();
        }
        public void GetList()
        {   
            lv2.ItemsSource = Singleton.ItemList;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            lv2.ItemsSource = null;
            lv2.ItemsSource = Singleton.ItemList;
        }
        public void UpdateList()
        {
            
            lv2.ItemsSource = Singleton.ItemList;
            lv2.ItemsSource = null;
        }
        public void ClearList()
        {
            Singleton.ItemList.Clear();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ClearList();
        }
        

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            InFile("ListAdded.txt");
        }
         public void InFile(string filename)
        {
            try
            {
                StreamWriter stream = new StreamWriter(filename);
                foreach (var it in lv2.ItemsSource)
                {
                    stream.WriteLine(it);
                }
                stream.Close();
               if(MessageBox.Show("Ошибка загружен успешно! Открыть файл? ","", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                Process.Start(filename);
              else
                   return;
                
            }
            catch 
            {
                MessageBox.Show("Ошибка загрузки в файл!");
            }
        }
        public void ClearFile(string filename)
        {
            string nol = null;
            File.WriteAllText(filename, nol);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ClearFile("ListAdded.txt");
        }
    }
}
