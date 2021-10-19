using OOP.Data;
using OOP.Data.DataSource;
using OOP.Model;
using System.Collections.Generic;

namespace OOP.UI.DataAccess
{
    public class EmployeeDataAccess
    {
        private readonly AbstractDataSource _dataSource;

        public EmployeeDataAccess(AbstractDataSource dataSource)
        {
            _dataSource = dataSource;
        }
    
        public List<Employee> GetEmployees()
        {
            //Todo:
            //Get All Employees from Data Source
            var employees = _dataSource.ProvideEmployees();
            return employees;
        }
    }
}
