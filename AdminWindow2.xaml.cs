using Itogovayaa.itogovayaaDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace Itogovayaa
{
    /// <summary>
    /// Логика взаимодействия для AdminWindow2.xaml
    /// </summary>
    public partial class AdminWindow2 : Page
    {
        staff_TableAdapter staff_ = new staff_TableAdapter();
        authorization_TableAdapter auto = new authorization_TableAdapter();
        public AdminWindow2()
        {
            InitializeComponent();
            grid2.ItemsSource = staff_.GetData();
            combobox.ItemsSource = auto.GetData();
            combobox.DisplayMemberPath = "Логин";
            combobox.SelectedValuePath = "Айди";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (grid2.SelectedItem != null)
            {
                object id = (grid2.SelectedItem as DataRowView).Row[0];
                staff_.UpdateQuery2(sur_name.Text, name_.Text, father_name.Text,Convert.ToInt32(combobox.SelectedValue), Convert.ToInt32(id));
                grid2.ItemsSource = staff_.GetData();
            }
        }

        private void grid2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (grid2.SelectedItem != null)
            {
                sur_name.Text = (grid2.SelectedItem as DataRowView).Row[1].ToString();
                name_.Text = (grid2.SelectedItem as DataRowView).Row[2].ToString();
                father_name.Text = (grid2.SelectedItem as DataRowView).Row[3].ToString();
                combobox.Text = (grid2.SelectedItem as DataRowView).Row[4].ToString();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            staff_.InsertQuery2(sur_name.Text, name_.Text, father_name.Text, combobox.SelectedIndex+1);
            grid2.ItemsSource = staff_.GetData();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (grid2.SelectedValue != null)
            {
                var value = (grid2.SelectedValue as DataRowView).Row[0];
                staff_.DeleteQuery((int)value);
                grid2.ItemsSource = staff_.GetData();
            }
            else
            {
                MessageBox.Show("Неверные данные!");
            }

        }
    }
}
