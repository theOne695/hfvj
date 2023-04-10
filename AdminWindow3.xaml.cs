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
using System.Xml.Linq;

namespace Itogovayaa
{
    /// <summary>
    /// Логика взаимодействия для AdminWindow3.xaml
    /// </summary>
    public partial class AdminWindow3 : Page
    {
        authorization_TableAdapter auto = new authorization_TableAdapter();
        role_TableAdapter role_ = new role_TableAdapter();
        public AdminWindow3()
        {
            InitializeComponent();
            grid3.ItemsSource = auto.GetData();
            chel.ItemsSource = role_.GetData();
            chel.DisplayMemberPath = "Наименование";
            chel.SelectedValuePath = "Айди";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            auto.InsertQuery1(login.Text, password.Text, chel.SelectedIndex+1);
            grid3.ItemsSource = auto.GetData();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (grid3.SelectedItem != null)
            {
                object id = (grid3.SelectedItem as DataRowView).Row[0];
                auto.UpdateQuery1(login.Text, password.Text, Convert.ToInt32(chel.SelectedValue), Convert.ToInt32(id));
                grid3.ItemsSource = auto.GetData();
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (grid3.SelectedValue != null)
            {
                var value = (grid3.SelectedValue as DataRowView).Row[0];
                auto.DeleteQuery((int)value);
                grid3.ItemsSource = auto.GetData();
            }
            else
            {
                MessageBox.Show("Неверные данные!");
            }
        }

        private void grid3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (grid3.SelectedItem != null)
            {
                login.Text = (grid3.SelectedItem as DataRowView).Row[1].ToString();
                password.Text = (grid3.SelectedItem as DataRowView).Row[2].ToString();
                chel.Text = (grid3.SelectedItem as DataRowView).Row[3].ToString();
            }
        }
    }
}
