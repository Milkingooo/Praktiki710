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

namespace WpfApp7
{
    /// <summary>
    /// Логика взаимодействия для Regist.xaml
    /// </summary>
    public partial class Regist : Window
    {
 
        public Regist()
        {
            InitializeComponent();
            UsersSingleton.UserList = new List<string>();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddUser(tb.Text, tb1.Text);
        }
        public void AddUser(string username, string pass)
        {
            try
            {
                if (username != null && pass != null)
                {
                        UsersSingleton.UserList.Add(username);
                        UsersSingleton.UserList.Add(pass);

                        MainWindow mainWindow = new MainWindow();
                        mainWindow.Show();
                        Close();
                }
                else
                {
                    MessageBox.Show("Вы ввели не всё!");
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
