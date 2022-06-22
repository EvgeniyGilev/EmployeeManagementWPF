using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Interfaces
{
    public interface IEmployeesViewModel
    {
        ObservableCollection<Employee> Employees { get; set; }
        string Filter { get; set; }
        string CountEmployees { get; set; }
    }
}
