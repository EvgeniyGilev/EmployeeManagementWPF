using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Unity;
using EmployeeManagement.Interfaces;
using EmployeeManagement.Repositories;
using EmployeeManagement.ViewModels;
using EmployeeManagement.Views;
using EmployeeManagement.Models;

namespace EmployeeManagement
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            IUnityContainer unityContainer = new UnityContainer();

            unityContainer.RegisterType<ILogger, Logger>();
            unityContainer.RegisterType<IEmployeeViewModel, EmployeeViewModel>();

            unityContainer.RegisterType<IEmployeeRepository, EmployeeRepository>();
            unityContainer.RegisterType<IEmployeesViewModel, EmployeesViewModel>();

            unityContainer.Resolve<Views.EmployeesView>().Show();
        }
    }
}
