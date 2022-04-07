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
    /// Логика взаимодействия для AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        public AddWindow()
        {
            InitializeComponent();
            cmb.ItemsSource = Расчет_премииEntities.getContext().Positions.ToList();
            cmbgrade.ItemsSource = Расчет_премииEntities.getContext().Grades.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Employees employees1 = new Employees();
            employees1.FIO = fio.Text;
            var pos = cmb.SelectedItem as Positions;
            employees1.Positions = pos;
            var grade = cmbgrade.SelectedItem as Grades;
            employees1.Positions.Grades = grade;
            employees1.Email = email.Text;
            employees1.Phone = phone.Text;
            Расчет_премииEntities.getContext().Employees.Add(employees1);
            Расчет_премииEntities.getContext().SaveChanges();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
