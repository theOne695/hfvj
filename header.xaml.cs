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

namespace Itogovayaa
{
    /// <summary>
    /// Логика взаимодействия для header.xaml
    /// </summary>
    public partial class header : Window
    {
        public header()
        {
            InitializeComponent();
            AdminWindow adminWindow = new AdminWindow();
            MyFrame.Content = adminWindow;
        }

        private void RadioButton_Click_1(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new AdminWindow();
        }

        private void RadioButton_Click_2(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new AdminWindow2();
        }

        private void RadioButton_Click_3(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new AdminWindow3();
        }
    }
}
