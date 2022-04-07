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
    /// Логика взаимодействия для EditWindow.xaml
    /// </summary>
    public partial class EditWindow : Window
    {
        Employees employees1;
        public EditWindow(Employees employees)
        {
            InitializeComponent();
            employees1 = employees;
            fio.Text = employees1.FIO.ToString();
            email.Text = employees1.Email.ToString();
            phone.Text = employees1.Phone.ToString();
            cmb.ItemsSource = Расчет_премииEntities.getContext().Positions.ToList();
            cmb.SelectedItem = employees1.Positions;
            cmbgrade.ItemsSource = Расчет_премииEntities.getContext().Grades.ToList();
            cmbgrade.SelectedItem = employees1.Positions.Grades;
            minSalary.Text = employees1.Positions.Grades.Min_Salary.ToString();
            maxSalary.Text = employees1.Positions.Grades.Max_Salary.ToString();
         
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            employees1.FIO = fio.Text;
            var pos = cmb.SelectedItem as Positions;
            employees1.Positions = pos;
            var grade = cmbgrade.SelectedItem as Grades;
            employees1.Positions.Grades = grade;
            employees1.Email = email.Text;
            employees1.Phone = phone.Text;
            Расчет_премииEntities.getContext().SaveChanges();
            this.Close();
        }
    }
}
