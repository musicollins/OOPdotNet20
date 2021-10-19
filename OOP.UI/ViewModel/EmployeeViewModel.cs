using OOP.Model;
using OOP.UI.DataAccess;
using System.Collections.Generic;

namespace OOP.UI.ViewModel
{
    public class EmployeeViewModel
    {
        private readonly EmployeeDataAccess _dataAccess;

        public List<Employee> Employees { get; private set; }

        public EmployeeViewModel(EmployeeDataAccess dataAccess)
        {
            Employees = new List<Employee>();
            _dataAccess = dataAccess;
        }
        public void LoadEmployees()
        {
            //Todo
            //Load All Employees from DataAccess
            var employees = _dataAccess.GetEmployees();

            Employees.AddRange(employees);

        }
    }
}
