using OOP.Data;
using OOP.Data.DataSource;
using OOP.UI.DataAccess;
using OOP.UI.ViewModel;
using System;

namespace OOP.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractDataSource dataSource_MockData = new EmployeeDataSource_MockData();
            AbstractDataSource dataSource_Db = new EmployeeDataSource_Database();


            EmployeeDataAccess dataAccess = new EmployeeDataAccess(dataSource_Db);
            EmployeeViewModel viewModel = new EmployeeViewModel(dataAccess);
            viewModel.LoadEmployees();

            foreach (var item in viewModel.Employees)
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Email);
                Console.WriteLine();
            }
        }
    }
}
