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

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            datagrid.ItemsSource = Расчет_премииEntities.getContext().Employees.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var selected = datagrid.SelectedItem as Employees;
            EditWindow editWindow = new EditWindow(selected);
            editWindow.Closed += EditWindow_Closed;
            editWindow.Show();
        }

        private void EditWindow_Closed(object sender, EventArgs e)
        {
            datagrid.ItemsSource = Расчет_премииEntities.getContext().Employees.ToList();
            datagrid.Items.Refresh();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AddWindow addWindow = new AddWindow();
            addWindow.Closed += EditWindow_Closed;
            addWindow.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var selected = datagrid.SelectedItem as Employees;
            DeleteWindow deleteWindow = new DeleteWindow(selected);
            deleteWindow.Closed += EditWindow_Closed;
            deleteWindow.Show();
        }
    }
}
