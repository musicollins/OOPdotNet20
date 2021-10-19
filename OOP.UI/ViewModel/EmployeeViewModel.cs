using OOP.Model;
using System.Collections.Generic;

namespace OOP.UI.ViewModel
{
    public class EmployeeViewModel
    {
        public List<Employee> Employees { get; set; }

        public void LoadEmployees()
        {
            //Todo
            //Load All Employees from DataAccess

        }
    }
}
