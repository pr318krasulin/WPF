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

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для DeleteWindow.xaml
    /// </summary>
    public partial class DeleteWindow : Window
    {
        Employees employees;
        public DeleteWindow(Employees employees)
        {
            InitializeComponent();
            this.employees = employees;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Расчет_премииEntities.getContext().Employees.Remove(employees);
            Расчет_премииEntities.getContext().SaveChanges();
            this.Close();
        }
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
