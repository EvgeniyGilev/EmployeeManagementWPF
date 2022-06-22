using EmployeeManagement.Interfaces;
using EmployeeManagement.Models;
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

namespace EmployeeManagement.Views
{
    /// <summary>
    /// Логика взаимодействия для EmployessView.xaml
    /// </summary>
    public partial class EmployeesView : Window
    {
        IEmployeesViewModel _employeesViewModel;
        IEmployeeViewModel _employeeViewModel;

        public EmployeesView(IEmployeesViewModel employeesViewModel, IEmployeeViewModel employeeViewModel)
        {

            _employeesViewModel = employeesViewModel;
            _employeeViewModel = employeeViewModel;

            InitializeComponent();
            DataContext = employeesViewModel;

           
        }

        private void ListView_PreviewMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var item = (sender as ListView).SelectedItem;

            if (item is null)
            {
                return;
            }
            else
            {
                var employee = item as Employee;

                _employeeViewModel.Employee = employee;

                var employeeView = new EmployeeView(_employeeViewModel);

                employeeView.Show();
                /*
                StringBuilder emplInfo = new StringBuilder();
                emplInfo.Append("Сотрудник " + employee.FirstName);
                emplInfo.Append(" " + employee.LastName + ", ");
                emplInfo.Append(employee.Age + " года/лет, ");
                emplInfo.Append("работает в компании " + employee.CompanyName);
                emplInfo.Append(" в городе " + employee.CityName);
                emplInfo.Append(" в должности " + employee.Position + "!");

                MessageBox.Show(emplInfo.ToString());
                */
            }
        }
    }
}
