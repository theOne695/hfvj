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
    /// Логика взаимодействия для header2.xaml
    /// </summary>
    public partial class header2 : Window
    {
        public header2()
        {
            InitializeComponent();
            tovari tovari = new tovari();
            MyFrame.Content = tovari;
        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new tovari();
        }
    }
}
