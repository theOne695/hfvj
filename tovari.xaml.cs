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
using Itogovayaa.itogovayaaDataSetTableAdapters;

namespace Itogovayaa
{
    /// <summary>
    /// Логика взаимодействия для tovari.xaml
    /// </summary>
    public partial class tovari : Page
    {
        product_TableAdapter adapter = new product_TableAdapter();
        
        public tovari()
        {
            InitializeComponent();
            grid.ItemsSource = adapter.GetData();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            adapter.InsertQuery(count.Text, sub_.Text);
            grid.ItemsSource = adapter.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void grid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
