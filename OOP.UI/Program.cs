using Autofac;
using OOP.Data;
using OOP.UI.DataAccess;
using OOP.UI.Startup;
using OOP.UI.ViewModel;
using System;

namespace OOP.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            //var viewModel = new EmployeeViewModel(
            //    new EmployeeDataAccess(
            //        new EmployeeDataSource_MockData()));

            var autofacContainer = new DiContainer();
            var viewModel = autofacContainer.Container().Resolve<EmployeeViewModel>();
            
            viewModel.LoadEmployees();

            foreach (var emp in viewModel.Employees)
            {
                Console.WriteLine(emp.Name);
            }
        }
    }
}
